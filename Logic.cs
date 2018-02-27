using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Logic
    {
        List<Card> SetOfPlayer = new List<Card>();
        List<Card> SetOfComputer = new List<Card>();
        static Random random = new Random();

        public void GenerateStartingSets()
        {
            for (int i = 0; i < 2; i++)
            {
                SetOfPlayer.Add(GenerateCard());
                SetOfComputer.Add(GenerateCard());
            }
        }

        public void GetCard()
        {
            SetOfPlayer.Add(GenerateCard());
            SetOfComputer.Add(GenerateCard());
        }

        private Card GenerateCard()
        {
            int weight = random.Next(2, 14);
            switch (weight)
            {
                case 2:

                    return new Card("Two", 2);

                case 3:

                    return new Card("Three", 3);

                case 4:

                    return new Card("Four", 4);

                case 5:

                    return new Card("Five", 5);

                case 6:

                    return new Card("Six", 6);

                case 7:

                    return new Card("Seven", 7);

                case 8:

                    return new Card("Eight", 8);

                case 9:

                    return new Card("Nine", 9);

                case 10:

                    return new Card("Ten", 10);

                case 11:

                    return new Card("Ace", 11);

                case 12:

                    return new Card("King", 10);

                case 13:

                    return new Card("Lady", 10);

                case 14:

                    return new Card("Valet", 10);

                default:

                    return new Card("Err", 0);
            }

        }

        public int CheckValidSum()
        {
            int sumOfPlayer = CalculatePlayerSum();
            
            int sumOfComputer = CalculateComputerSum();
            
            if (sumOfComputer > 21)
                return 2;
            if (sumOfPlayer > 21)
                return 3;

            return 4;

        }

        private int CalculatePlayerSum()
        {
            int sumOfPlayer = 0; 

            foreach (var item in SetOfPlayer)
            {
                
                sumOfPlayer += item.weight;
            }

            return sumOfPlayer;
        }

        private int CalculateComputerSum()
        {
            int sumOfComputer = 0;

            foreach (var item in SetOfComputer)
            {
               
                sumOfComputer += item.weight;
            }


            return sumOfComputer;
        }



        public List<Card> GetSetOfPlayer()
        {

            return SetOfPlayer;

        }
        public int OpenCards()
        {

            int sumOfPlayer = CalculatePlayerSum();

            int sumOfComputer = CalculateComputerSum();

            if (sumOfPlayer > sumOfComputer)
                return 0;
            else
                return 1;

        }

        public int ComputerStep()
        {
            if (CalculateComputerSum() < 17)
            {
                GetCard();
                int flag = CheckValidSum();
                return flag;
            }
            else
                return OpenCards();
        }
    }
}
