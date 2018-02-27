using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
        class Game
        {
            UserInterface ui = new UserInterface();
            Logic logic = new Logic();

            public void Start()
            {
                ui.ShowGreeting();
                int chose;
                do
                {
                    ui.ShowStartingMenu();
                    chose = Convert.ToInt32(Console.ReadLine());
                    switch (chose)
                    {
                        case 1:
                            Play();
                            logic = new Logic();
                            break;
                        default:
                            break;
                    }
                } while (chose != 2);
                ui.ShowParting();
            }

            private void Play()
            {
                int chose = 0;

                logic.GenerateStartingSets();

                bool isComputerStep = false;
        
                do
                {
                    if (isComputerStep == true)
                    {
                        int flag = logic.ComputerStep();
                        switch (flag)
                        {
                            case 0:
                                ui.ShowComputerTookInf();
                                ui.ShowPlayerWin();
                                return;
                            case 1:
                                ui.ShowComputerTookInf();
                                ui.ShowComputerWin();
                                return;
                            case 2:
                                ui.ShowComputerOpenInf();
                                ui.ShowPlayerWin();
                                return;
                            case 3:
                                ui.ShowComputerOpenInf();
                                ui.ShowComputerWin();
                                return;
                            case 4:
                                break;
                        }
                        isComputerStep = false;
                        continue;
                    }

                    ui.ShowSetOfPlayer(logic.GetSetOfPlayer());
                    ui.ShowPlayingMenu();

                    chose = Convert.ToInt32(Console.ReadLine());
                    switch (chose)
                    {
                        case 1:
                            int winner = logic.OpenCards();
                            switch (winner)
                            {
                                case 0:
                                    ui.ShowPlayerWin();
                                    return;
                                case 1:
                                    ui.ShowComputerWin();
                                    return;
                            }
                            break;
                        case 2:
                            logic.GetCard();
                            int flag = logic.CheckValidSum();

                            switch (flag)
                            {
                                case 2:
                                    ui.ShowPlayerWin();
                                    return;
                                case 3:
                                    ui.ShowComputerWin();
                                    return;
                                case 4:
                                    break;
                            }
                            isComputerStep = true;
                            break;
                        default:
                            break;
                    }
                } while (chose != 3);

            }
        }
    }
}
}
