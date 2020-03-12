using System;
using System.Collections.ObjectModel;
using Annonces.Mobile.Models;

namespace Annonces.Mobile.ViewModels
{
    public class ListOfAnnonces
    {
        private ObservableCollection<Annonce> myList;

        public ObservableCollection<Annonce> MyList
        {
            get { return myList; }
            set { myList = value; }
        }
        public ListOfAnnonces()
        {
            MyList = new ObservableCollection<Annonce>();
        }

    }
}
