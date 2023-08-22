using Sharing.Models;
using SQLite;
using SQLiteNetExtensions.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Sharing.Services
{
    

    public class DatabaseHelper
    {
        private SQLiteConnection database;

        public DatabaseHelper(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<UserModel>();
        }

        public List<UserModel> GetUsers()
        {
            return database.GetAllWithChildren<UserModel>();
        }

        public UserModel GetUserByUsername(string username)
        {
            return database.Table<UserModel>().FirstOrDefault(u => u.UserName == username);
        }

        public void InsertUser(UserModel user)
        {
            database.InsertWithChildren(user);
        }

        public bool DoesUserExist(string username)
        {
            return database.Table<UserModel>().Any(u => u.UserName == username);
        }

        // Add more methods as needed (e.g., update user, delete user, etc.)
    }

}
