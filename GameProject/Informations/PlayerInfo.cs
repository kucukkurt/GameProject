using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class PlayerInfo
    {
        public void playerInfo(Player player)
        {
            Console.WriteLine("User Id :{0}", player.UserId);

            Console.WriteLine("Nick Name :{0}", player.NickName);

            Console.WriteLine("Name :{0}", player.Name);

            Console.WriteLine("Surname :{0}", player.SurName);

            Console.WriteLine("Birth of Year :{0}", player.BirthOfYear);

            Console.WriteLine("Gender :{0}", player.Gender);

        }
    }
}
