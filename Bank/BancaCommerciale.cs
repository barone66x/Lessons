using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Bank
{
    public class BancaCommerciale : Banca //, IVersamento, ITrasferimento, IPrelievo
    {
        private readonly string GruppoId;
        private List<Cliente> clienti;
        private List<ContoCorrente> conti;
        private List<Movimento> movimenti;

        public BancaCommerciale(string nomebanca, string stato, Monete moneta, string partitaiva, double capitale, string id) : base(nomebanca, stato, moneta, partitaiva, capitale)
        {
            Nomebanca = nomebanca;
            Stato = stato;
            Moneta = moneta;
            PartitaIva = partitaiva;
            Capitale = capitale;
            GruppoId = id;
            clienti = new List<Cliente>();
            conti = new List<ContoCorrente>();
            movimenti = new List<Movimento>();


        }
        public class ContoCorrente //: IVersamento, IPrelievo
        {
            public string Iban { get; set; }
            public string IdProprietario { get; set; }
            public double Saldo { get; set; }
            public bool Blocked { get; set; }
            private List<Movimento> Movimenti;
            //public DateTime DateToUnlock { get; set; }
            private DateTime DateToUnlock;
            public ContoCorrente(string iban, Cliente cliente)
            {
                Iban = iban;
                IdProprietario = cliente.IdCliente;
            }

            public ContoCorrente()
            {

            }

            public void setMovimenti(List<Movimento> movimentiCopia)
            {
                Movimenti = movimentiCopia;
            }


            internal void Prelievo(double cifra)
            {
                Saldo -= cifra;

            }

            internal void Versamento(double cifra)
            {
                Saldo += cifra;


            }

            internal void GetMovimenti()
            {
                foreach (var moviment in Movimenti)
                    Console.WriteLine($"data: {moviment.Ora} operazione: {moviment.Operazione} " +
                        $"ammontare: {moviment.Ammontare}  iban: {moviment.Iban} " +
                        $"banca: {moviment.Banca} cliente: {moviment.IdCliente}");
            }




        }

        public override void Prestiti() { }

        #region INTERFACCIA UTENTE
        public void Accesso(Persona persona)
        {
            Console.WriteLine("inserisci 1 per registrarti, 2 per accedere, 3 per uscire");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Registrati(persona);
                    break;
                case 2:
                    Accedi(persona);
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("numero sbagliato");
                    return;
            }
        }

        public void MenuCliente(Cliente cliente) //menù del cliente loggato
        {

            Console.WriteLine("scegli 1 per creare un conto, 2 per visualizzare i tuoi conti, 3 per uscire");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    CreaConto(cliente); //metodo che crea un nuovo conto al cliente
                    MenuCliente(cliente);
                    break;
                case 2:

                    string iban = VisualizzaConti(cliente);  //metodo che visualizza tutti i conti con idProprietario == a idCliente
                    MenuConto(iban); //Chiama il menu del conto passando come parametro l'iban del conto selezionato
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("scelta sbagliata");
                    return;



            }
        }



        public void Registrati(Persona persona)
        {
            var oggi = DateTime.Now;

            int eta = oggi.Year - persona.DataNascita.Year;
            if (oggi.Month < persona.DataNascita.Month)
            {
                eta -= 1;
            }
            else if (oggi.Month == persona.DataNascita.Month)
            {
                if (oggi.Day < persona.DataNascita.Day) { eta -= 1; }
            }

            if (eta >= 18)
            {
                Console.WriteLine("inserisci username: ");
                string username = Console.ReadLine();
                if (ControllaUser(username))
                {
                    Console.WriteLine("utente già registrato");
                    return;
                }
                Console.WriteLine("inserisci password");
                string password = Console.ReadLine();
                clienti.Add(new(persona, username, password));
                var cliente = clienti.Last();
                Console.WriteLine($"Registrazione Effettuata {cliente.Username} ");
                MenuCliente(cliente);

            }
            else
            {
                Console.WriteLine("non puoi registrarti se hai meno di 18 anni");
                return;
            }


        }

        public void MenuConto(string iban)
        {
            ContoCorrente contoSelezionato = (
                from c in conti
                where iban == c.Iban
                select c).FirstOrDefault();
            Console.WriteLine("Scegli 1 per prelevare, 2 per versare, 3 per effettuare un trasferimento, 4 per visualizzare storico movimenti 5 per tornare ai conti");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Prelievo(contoSelezionato); //chiama il prelievo della banca, che effettua controlli
                    MenuConto(iban);
                    break;
                case 2:

                    Versamento(contoSelezionato); //chiama il versamento della banca, che effettua controlli
                    MenuConto(iban);
                    break;
                case 3:

                    Trasferimento(contoSelezionato); //chiama il trasferimento della banca, che effettua controlli e chiama
                    //deposito e versamento dei conti corrispondenti
                    MenuConto(iban);
                    break;
                case 4:
                    Movimenti(contoSelezionato);
                    MenuConto(iban);
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("numero sbagliato");
                    return;

            }
        }

        public bool ControllaUser(string username)
        {
            bool exist = false;
            foreach (Cliente cliente in clienti)
            {
                if (cliente.Username == username) { exist = true; }
            }
            return exist;
        }

        public void Accedi(Persona persona)
        {
            Console.WriteLine("inserisci username: ");
            string username = Console.ReadLine();
            Console.WriteLine("inserisci password: ");
            string password = Console.ReadLine();

            try
            {
                Cliente cliente =
                    (from c in clienti
                     where c.Username == username && c.Password == password
                     select c).FirstOrDefault();
                MenuCliente(cliente);
            }
            catch (Exception ex)
            {
                Console.WriteLine("utente non trovato o password sbagliata");
                Accesso(persona);
            }


        }

        public string VisualizzaConti(Cliente cliente)
        {
            List<ContoCorrente> contiCliente = (
                from c in conti
                where c.IdProprietario == cliente.IdCliente
                select c).ToList();
            int i = 0;
            foreach (var conto in contiCliente)
            {
                Console.WriteLine($"numero conto: {i} iban: {conto.Iban}");
                i += 1;
            }
            int input = int.Parse(Console.ReadLine());
            return contiCliente[input].Iban;

        }


        #endregion



        #region METODI ESTERNI CONTI

        private void Trasferimento(ContoCorrente contoSelezionato)
        {
            Console.WriteLine();

        }
        private void Versamento(ContoCorrente contoSelezionato)
        {
            Console.WriteLine($"conto {contoSelezionato.Iban} ");
            SaldoConto(contoSelezionato);
            Console.WriteLine("inserisci cifra da versare:");

            double cifra = Double.Parse(Console.ReadLine());

            contoSelezionato.Versamento(cifra);
            SaldoConto(contoSelezionato);


        }

        public void BloccaConto()
        {

        }

        public void ControllaConto()
        {

        }

        public void SaldoConto(ContoCorrente conto)
        {
            Console.WriteLine($"saldo: {conto.Saldo} {Moneta}");
        }

        public void Movimenti(ContoCorrente conto)
        {
            conto.GetMovimenti();
        }

        public void CreaConto(Cliente cliente)
        {
            Console.WriteLine("creazione conto in corso...");
            Random rnd = new Random();
            int testIban = rnd.Next();
            string iban = testIban.ToString();

            conti.Add(new(testIban.ToString(), cliente));
            Console.WriteLine("conto creato, ritorno alla homepage");
            MenuCliente(cliente);
            //****
            //foreach (ContoCorrente conto in conti)
            //{
            //    if (conto.idProprietario == cliente.idCliente)
            //    {
            //        Console.WriteLine(conto.Iban);
            //    }
            //}
            //******

        }

        private void Prelievo(ContoCorrente contoSelezionato)
        {
            Console.WriteLine($"conto {contoSelezionato.Iban} ");
            SaldoConto(contoSelezionato);
            Console.WriteLine("inserisci cifra da prelevare:");

            double cifra = Double.Parse(Console.ReadLine());
            if (contoSelezionato.Saldo >= cifra)
            {
                contoSelezionato.Prelievo(cifra);
                SaldoConto(contoSelezionato);

            }
            else
            {
                Console.WriteLine("saldo sul conto insufficiente");
                return;
            }

        }

        #endregion



        #region CARICA IN MEMORIA
        public void CaricaMemoria()
        {
            string pathMovimenti = @$"C:\Users\mattia.ligreci\Documents\Test\banche\Movimenti_{Nomebanca}.csv";
            string pathClienti = @$"C:\Users\mattia.ligreci\Documents\Test\banche\Clienti_{Nomebanca}.csv";
            var pathConti = @$"C:\Users\mattia.ligreci\Documents\Test\banche\ContiCorrenti_{Nomebanca}.csv";
            try
            {

                var linesMovimenti = FileLoader.ReadfromFile(pathMovimenti);
                movimenti = FileLoader.CreateObject<Movimento>(linesMovimenti);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non è stato possibile caricare tutti i movimenti della banca {Nomebanca}");
                return;
            }


            try
            {
                var linesClienti = FileLoader.ReadfromFile(pathClienti);
                clienti = FileLoader.CreateObject<Cliente>(linesClienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non è stato possibile caricare tutti i clienti della banca {Nomebanca}");
                return;
            }


            try
            {
                var linesConti = FileLoader.ReadfromFile(pathConti);
                conti = FileLoader.CreateObject<ContoCorrente>(linesConti);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"non è stato possibile caricare tutti i conti della banca {Nomebanca}");
                return;
            }
            CaricaConti();


            //carica ogni lista interna di movimenti del conto 
        }


        public void CaricaConti()
        {
            List<Movimento> list = new List<Movimento>();
            foreach (var conto in conti)
            {
                list = (
                    from m in movimenti
                    where m.Iban == conto.Iban
                    select m).ToList();
                conto.setMovimenti(list);

            }

        }

        #endregion




    }




}

