using Sharing.Services;
using Sharing.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharing
{
    public partial class App : Application
    {
        public static DatabaseHelper Database { get; private set; }

        public App() 
        {
            InitializeComponent();


            // Get the path to the local app's database file
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydatabase.db");

            // Initialize the database helper
            Database = new DatabaseHelper(dbPath);


            DependencyService.Register<ILoginService, LoginService>();
            MainPage = new NavigationPage(new LoginPage2());





            //  DependencyService.Register<MockDataStore>();
            // MainPage = new AppShell(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
