using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerManager
    {
        PlayerInfo playerInfo = new PlayerInfo();
        public Player AddUser(Player player)
        {
            Console.Write("Nick Name :");
            player.NickName = Console.ReadLine();

            Console.Write("Name :");
            player.Name = Console.ReadLine();

            Console.Write("Surname :");
            player.SurName = Console.ReadLine();

            Console.Write("Date of Birth :");
            player.BirthOfYear = Console.ReadLine();

            Console.Write("Identity no :");
            player.IdentityNo = Console.ReadLine();

            Console.Write("Gender :");

            player.Gender = Convert.ToBoolean(Console.ReadLine());

            return player;
        }

        public void DeleteUser(List<Player> playerManager)
        {
            Console.Write("Please search user(Nickname) :");
            string _nickName = Console.ReadLine();
            int i = 0;

            foreach (var NickName in playerManager)
            {

                if (_nickName == playerManager[i].NickName)
                {
                    Console.WriteLine("User was found!");
                    playerInfo.playerInfo(playerManager[i]);

                    Console.Write("Delete this user ? (y) or (n) ?");
                    char _quest = Convert.ToChar(Console.ReadLine());

                    if (_quest == 'y')
                    {
                        playerManager.RemoveAt(i);
                        Console.WriteLine("User deleted successfully.");
                        break;
                    }
                    
                }
                i++;
            }
        }

        public void UpdateUser(List<Player> playerManager)
        {
            Console.Write("Please search user(Nickname) :");
            string  _nickName = Console.ReadLine();
            int i = 0;

                foreach (var NickName in playerManager)
                {

                    if (_nickName == playerManager[i].NickName)
                    {
                        Console.WriteLine("User was found!");
                        playerInfo.playerInfo(playerManager[i]);

                        Console.Write("Update Nick Name :");
                        _nickName = Console.ReadLine();
                        playerManager[i].NickName = _nickName;
                    }
                    i++;
                }

        }
    }
}
