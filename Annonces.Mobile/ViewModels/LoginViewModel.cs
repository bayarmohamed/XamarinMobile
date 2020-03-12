using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Annonces.Mobile.ViewModels
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Action DisplayInvalidLoginPrompt;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand SubmitCommand { get; set; }
        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (!Email.Equals("mohamed") && !Password.Equals("bayar"))
            {
                DisplayInvalidLoginPrompt();
            }
        }
        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
