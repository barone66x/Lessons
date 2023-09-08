using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    internal class Player
    {
        private List<Content> content;
        // private string songInput;
        private int numberSongInput;
        private string choice;
        private string menuChoice;
        private Content inPlaying;

        public Player(List<Content> list)
        {
            content = list;
        }

        public void Start()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            ShowList();
            Console.WriteLine("choose number of content");
            numberSongInput = int.Parse(Console.ReadLine());

            CurrentPlay(numberSongInput);
            Console.WriteLine("- - - - - - - - - - - - - - ");



        }

        public void ShowList()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            int i = 0;
            foreach (var item in content)
            {

                Console.WriteLine($"{i}  {item.title}");
                i += 1;

            }
            Console.WriteLine("- - - - - - - - - - - - - - ");

        }


        public void CurrentPlay(int numberInput)
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            inPlaying = content[numberInput];
            Console.WriteLine($"Now in Playing: {inPlaying.title}");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Menu.ShowMenu();
            menuChoice = Scegli();
            NextAction(menuChoice);




        }


        public void Next()
        {
            if (numberSongInput < content.Count - 1)
            {
                numberSongInput += 1;

            }
            else
            {
                numberSongInput = 0;
            }

            CurrentPlay(numberSongInput);


        }

        public void Previous()

        {
            if (numberSongInput > 0)
            {
                numberSongInput -= 1;

            }
            else
            {
                numberSongInput = content.Count - 1;
            }

            CurrentPlay(numberSongInput);

        }

        public void Pause()
        {
            Console.Write("Now In Pause");
            Menu.ShowMenu();
            menuChoice = Scegli();
            NextAction(menuChoice);


        }


        public void Exit()
        {
            return;
        }

        public string Scegli()
        {
            //Menu.ShowMenu();
            menuChoice = Console.ReadLine();
            return menuChoice;
        }

        public void NextAction(string choice)
        {
            switch (choice)

            {
                case "f":
                    Next();

                    break;
                case "b":
                    Previous(); break;
                case "p":
                    Pause(); break;
                case "e":
                    Exit(); break;
                default:
                    Console.WriteLine("scelta sbagliata");
                    return;

            }

        }
    }
}
