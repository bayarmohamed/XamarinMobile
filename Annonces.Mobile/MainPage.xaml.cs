using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Annonces.Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private Button btn;
        public MainPage()
        {
            InitializeComponent();
            btn = new Button();
            btn.Text = "OK";
            btn.Clicked += Btn_Clicked;
            btn.Clicked += Btn_Clicked1;
            StackLayout layout = new StackLayout();
            layout.Padding = new Thickness(0,100,0,0);
            layout.Orientation = StackOrientation.Vertical;
            layout.Children.Add(btn);
            Content = layout;

        }

        private void Btn_Clicked1(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Alerte", "Confirm", "Cancel");
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert","Alerte","Ok");
        }
    }
}
