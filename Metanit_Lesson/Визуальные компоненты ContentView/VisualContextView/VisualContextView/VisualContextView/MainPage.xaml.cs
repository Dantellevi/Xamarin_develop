using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisualContextView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> users = new List<string>()
            {
                "Иван Иванов",
                "Олег Кузнецов",
                "Денис Петров",
                "Иван Сидоров",
                "Петр Денисов"
            };
            ListView usersList = new ListView
            {
                ItemsSource = users
            };

            SearchView searchView = new SearchView();
            searchView.Search += (text) =>
            {
                if (!string.IsNullOrEmpty(text))
                {
                    usersList.ItemsSource = users.Where(u => u.Contains(text));
                }
                else
                {
                    usersList.ItemsSource = users;
                }
            };
            Content = new StackLayout { Children = { searchView, usersList } };
        }
    }
}
