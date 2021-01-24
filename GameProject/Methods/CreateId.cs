using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CreateId
    {
        public int UserId(Player player)
        {
            int _tempId;

            _tempId = player.UserId;

            if (_tempId == 0)
            {
                Random random = new Random();
                _tempId = random.Next(1, 100);
            }

            return _tempId;
        }
    }
}
