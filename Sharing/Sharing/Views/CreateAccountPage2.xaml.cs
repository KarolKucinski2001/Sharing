using Sharing.Models;
using Sharing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharing.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountPage2 : ContentPage
	{
		public CreateAccountPage2 ()
		{
			InitializeComponent();

        }

        //private void OnCreateAccountClicked(object sender, EventArgs e)
        //{
        //    string username = usernameEntry.Text;
        //    string password = passwordEntry.Text;
        //    string email = emailEntry.Text;

        //    // Create a new UserModel instance with the entered data
        //    UserModel newUser = new UserModel
        //    {
        //        UserName = username,
        //        Password = password,
        //        Email = email
        //        // Set other properties as needed
        //    };

        //    // Check if the user already exists
        //    if (App.Database.DoesUserExist(username))
        //    {
        //        errorMessageLabel.Text = "Username already exists";
        //        return;
        //    }

        //    // Perform any necessary validation on the entered data

        //    // Call a method to save the user data to the database or perform any other necessary actions
        //    App.Database.InsertUser(newUser);

        //    // Display a success message or navigate to a different page
        //    // Account created successfully
        //}


        //private void SaveUser(UserModel user)
        //{
        //    // Perform the logic to save the user to the database or any other data storage mechanism
        //    // For example, you can use your DatabaseHelper class

        //     App.Database.InsertUser(user); // Assuming you have a DatabaseHelper class with an InsertUser method
        //}
    }
}