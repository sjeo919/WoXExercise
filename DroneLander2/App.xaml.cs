﻿using Xamarin.Forms;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace DroneLander2
{
    public partial class App : Application
    {

        public static MainViewModel ViewModel { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLander2.MainPage());
        }

        protected override void OnStart()
        {
			// Handle when your app starts
			MobileCenter.Start("android=9c9bccaf-be03-4510-87e9-71ef7aab0e62;" +
				   "uwp={Your UWP App secret here};" +
				   "ios={Your iOS App secret here}",
				   typeof(Analytics), typeof(Crashes));
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
