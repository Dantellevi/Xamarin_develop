using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<string> Data = new List<string>()
            {
                "телефон1",
                "телефон2",
                "телефон3"
            };

            ListData.ItemsSource = Data;        //загружаем данные в ListView



        }



        private void ListData_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem!=null)
            {
                selected.Text = e.SelectedItem.ToString();
            }
        }
    }
}
