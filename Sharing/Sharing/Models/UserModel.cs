using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.Models
{
    public class UserModel
    {
       
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }

    }
}
