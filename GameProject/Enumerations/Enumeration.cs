using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    enum MainMenu
        {
            UserManagement = 1,
            Campaign,
            GameSales
        }

    enum UserManagement
    {
        NewUser = 1,
        UpdateUser,
        DeleteUser
    }

    enum Campaign
    {
        Entry = 1,
        Update,
        Delete
    }

    enum GameSales
    {
        ListofGame =1,
        CurrentGames,
        BuyAGame,
        GiveBack,

    }

 
}
