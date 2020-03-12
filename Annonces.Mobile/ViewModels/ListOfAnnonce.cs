using System;

using Xamarin.Forms;

namespace Annonces.Mobile.ViewModels
{
    public class ListOfAnnonce : ContentPage
    {
        public ListOfAnnonce()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

