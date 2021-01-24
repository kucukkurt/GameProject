using System;
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
                        UserManagement UserChoice = (UserManagement)Convert.ToInt32(Console.ReadLine());

                        switch (UserChoice)
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
                        // need to be write Campaign.
                        break;
                    case MainMenu.GameSales:
                        //need to be write Game Sales.
                        break;

                    default:
                        break;
                }    
                
            }

        }
    }
}
