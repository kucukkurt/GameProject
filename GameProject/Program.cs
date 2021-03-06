﻿using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player player = new Player();
            Player _player;
            CreateId createId = new CreateId();

            PlayerManager playerManager = new PlayerManager();
            List<Player> playerArray = new List<Player>();


            while (true)
            {
                Console.WriteLine("*****************************");
                Console.WriteLine("Welcome to the Game World!");
                Console.WriteLine("*****************************");
                Console.WriteLine("Please choose one of option");
                Console.WriteLine("*****************************");
                Console.WriteLine("1 - User Management\n2 - Campaign\n3 - Game Sales");

                MainMenu mainMenu = (MainMenu)Convert.ToInt32(Console.ReadLine());


                switch (mainMenu)

                {
                    case MainMenu.UserManagement:

                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("1 - New User\n2 - Update User\n3 - Delete User");
                        Console.WriteLine("*****************************");
                        UserManagement UserManagement = (UserManagement)Convert.ToInt32(Console.ReadLine());

                        switch (UserManagement)
                        {
                            case UserManagement.NewUser:
                                //_player = player;
                                _player = playerManager.AddUser(new Player());
                                _player.UserId = createId.UserId(_player);
                                playerArray.Add(_player);
                                break;

                            case UserManagement.UpdateUser:

                                playerManager.UpdateUser(playerArray);
                                break;

                            case UserManagement.DeleteUser:
                                playerManager.DeleteUser(playerArray);
                                break;
                            default:

                                break;
                        }
                        break;

                    case MainMenu.Campaign:

                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("1 - Entry Campaign\n2 - Update Campaign\n3 - Delete Campaign");
                        Console.WriteLine("*****************************");
                        Campaign UserCampaign = (Campaign)Convert.ToInt32(Console.ReadLine());


                        switch (UserCampaign)
                        {
                            case Campaign.Entry:
                                //todo need to be write here.
                                break;
                            case Campaign.Update:
                                //todo need to be write here.
                                break;
                            case Campaign.Delete:
                                //todo need to be write here.
                                break;
                            default:
                                //todo need to be write here.
                                break;
                        }
                        break;

                    case MainMenu.GameSales:

                        Console.Clear();
                        Console.WriteLine("*****************************");
                        Console.WriteLine("1 - List of Game\n2 - Current Games\n3 - Buy a Game\n4 - Give Back");
                        Console.WriteLine("*****************************");
                        GameSales UserGameSales = (GameSales)Convert.ToInt32(Console.ReadLine());

                        switch (UserGameSales)
                        {
                            case GameSales.ListofGame:
                                //todo need to be write here.
                                break;
                            case GameSales.CurrentGames:
                                //todo need to be write here.
                                break;
                            case GameSales.BuyAGame:
                                //todo need to be write here.
                                break;
                            case GameSales.GiveBack:
                                //todo need to be write here.
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }    
                
            }

        }
    }
}
