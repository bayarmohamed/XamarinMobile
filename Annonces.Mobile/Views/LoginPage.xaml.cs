using System;
using System.Collections.Generic;
using Annonces.Mobile.ViewModels;
using Xamarin.Forms;

namespace Annonces.Mobile.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            var vm = new LoginViewModel();
            this.BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Alert", "Message", "Ok");
            InitializeComponent();
          
        }

        
    }
}
