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




//using Sharing.Models;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Sharing.Services
//{
//    public class loginService : ILoginService
//    {
//        List<UserModel> userList = new List<UserModel>();


//        public loginService()
//        {
//            userList.Add(new UserModel { UserName = "user1", Password = "123456" }) ;  
//            userList.Add(new UserModel { UserName = "user2", Password = "1234567" }) ;  

//        }
//        public bool login(string username, string password)
//        {
//            foreach(var user in userList) 
//            {
//                if(username==user.UserName & password==user.Password)
//                {
//                    return true;    
//                }
//            }
//            return false;
//        }
//    }
//}
