using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SearchBar
{
    public partial class MainPage : ContentPage
    {

        private List<string> source = new List<string>()
        {
            "Harry",
            "Hermione",
            "Ron",
            "Moddy"
        };
        public MainPage()
        {
            InitializeComponent();
            myListView.ItemsSource = source;

        }



        private void mySearchBar_ButtonPressed(object sendler,EventArgs e)
        {
            string searchText = mySearchBar.Text.ToLower();
            IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
            if(result.Count()>0)
            {
                myListView.ItemsSource = result;
            }
            else
            {
                myListView.ItemsSource = new List<string>() {"Not Found" };
            }

        }

        private void mySearchBar_TextChanged(object sendler,TextChangedEventArgs e)
        {
            if(string.IsNullOrEmpty(e.NewTextValue.ToString()))
            {
                myListView.ItemsSource = source;
            }
            else
            {
                string searchText = mySearchBar.Text.ToLower();
                IEnumerable<string> result = source.Where(x => x.ToLower().Contains(searchText));
                if (result.Count() > 0)
                {
                    myListView.ItemsSource = result;
                }
                else
                {
                    myListView.ItemsSource = new List<string>() { "Not Found" };
                }
            }
        }



    }


   

}
