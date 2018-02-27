using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class UserInterface
    {
        public void ShowGreeting()
        {
            Console.WriteLine("Hello!\nPress Enter to continue!");
            Console.ReadKey();
        }

        public void ShowComputerTookInf()
        {
            Console.WriteLine("Computer took the card!\nPress Enter to continue!");
            Console.ReadKey();
        }

        public void ShowComputerOpenInf()
        {
            Console.WriteLine("Computer is opening the cards!\nPress Enter to continue!");
            Console.ReadKey();
        }
        public void ShowParting()
        {
            Console.WriteLine("Goodbye!");
            Console.ReadKey();

        }

        public void ShowStartingMenu()
        {

            Console.Clear();
            Console.Write("1.Start the round;\n2.Exit;\n:");

        }

        public void ShowPlayingMenu()
        {
            Console.Write("---------------------------\n1.Open cards;\n2.Get card;\n3.Leave the game;\n:");
        }

        public void ShowPlayerWin()
        {
            Console.Clear();
            Console.WriteLine("Player is winner!\nPress Enter to continue!");
            Console.ReadKey();
        }

        public void ShowComputerWin()
        {
            Console.Clear();
            Console.WriteLine("Computer is winner!\nPress Enter to continue!");
            Console.ReadKey();
        }
        public void ShowSetOfPlayer(List<Card> set)
        {
            Console.Clear();
            int sum = 0;
            foreach (var item in set)
            {
                Console.Write(item.type + " \n");
                sum += item.weight;
            }
            Console.WriteLine(sum);
        }
    }

}
