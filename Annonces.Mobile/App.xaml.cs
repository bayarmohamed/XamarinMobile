﻿using System;
using Annonces.Mobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Annonces.Mobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ListOfAnnoncesPage();
            //MainPage = new LoginPage();
            //MainPage = new MainPage();
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
