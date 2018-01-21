using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Context_Menu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async void Button1_Click(object sendler, EventArgs e)
        {
            string result = await DisplayActionSheet("Изменение цвета текста", "Отмена", null, "Красный", "Синий", "Желтый", "Зеленый");

            switch (result)
            {
                case "Красный":
                    {
                        Editor1.TextColor = Color.FromHex("F44336");
                        break;
                    }

                case "Синий":
                    {
                        Editor1.TextColor = Color.FromHex("296FF");
                        break;
                    }

                case "Желтый":
                    {
                        Editor1.TextColor = Color.Yellow;
                        break;
                    }

                case "Зеленый":
                    {
                        Editor1.TextColor = Color.Green;
                        break;
                    }
            }
        }
    }
}
