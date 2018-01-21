using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LIST_VIEW
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //MainListView.ItemsSource = new List<string>()
            //{
            //    "Harry Potter",
            //    "Hermiona Grengoy",
            //    "Уизли"
            //};


            MainListView.ItemsSource = new List<Person>()
            {
                new Person() {Name="Саня", Age=24 },
                new Person() {Name="антон", Age=23 },
                new Person() {Name="Андрей", Age=22 },
                new Person() {Name="Витек", Age=21 }
            };
        }
    }
}
