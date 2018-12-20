using leaddoubler.Services;
using leaddoubler.ViewModels;
using leaddoubler.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace leaddoubler
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            NavigationPage navigationPage = new NavigationPage(new AllFormsPage());
            navigationPage.BarBackgroundColor = Color.FromHex("#68A179");//#F0F6F2
            navigationPage.BarTextColor = Color.White;
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
