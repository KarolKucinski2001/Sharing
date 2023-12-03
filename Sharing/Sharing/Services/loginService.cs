using System;
using System.Collections.Generic;
using System.IO;
using Sharing.Models;
using Xamarin.Essentials;

namespace Sharing.Services
{
    public class LoginService : ILoginService
    {
        private readonly DatabaseHelper databaseHelper;

        public LoginService()
        {
            databaseHelper = new DatabaseHelper("/data/user/0/com.companyname.sharing/files/.local/share/mydatabase.db");
        }

        public bool login(string username, string password)
        {
            UserModel user = databaseHelper.GetUserByUsername(username);
            if (user != null && user.Password == password)
            {
                return true;
            }
            return false;
        }

       
    }
}


