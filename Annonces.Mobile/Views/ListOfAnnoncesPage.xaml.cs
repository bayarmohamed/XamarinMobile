using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Annonces.Mobile.Models;
using Xamarin.Forms;

namespace Annonces.Mobile.Views
{
    public partial class ListOfAnnoncesPage : ContentPage
    {
        private ObservableCollection<Annonce> myList;
        public ICommand commandAdd;
        public ICommand commandRemove;
        public ObservableCollection<Annonce> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public ListOfAnnoncesPage()
        {
            InitializeComponent();
            commandAdd = new Command(Execute);
            commandRemove = new Command(ExecuteRemove);
            MyList = new ObservableCollection<Annonce>();

            BindingContext = this;

            for (int i = 1; i < 10; i++)
            {
                MyList.Add(new Annonce { Id = i, Name = "Student" + i.ToString(), Address = "Address" + i.ToString() });
            }
            BindingContext = this;
            
            
            ContactsList.ItemsSource = MyList;
            btn.Command = commandAdd;
            Delete.Command = commandRemove;
        }

        private void ExecuteRemove(object obj)
        {
            MyList.Remove(MyList.Single(x=>x.Name=="Mohamed"));
        }

        private void Execute(object obj)
        {
            MyList.Add(new Annonce { Name = "Mohamed", Address = "Bousalem" });
        }
    }
}
