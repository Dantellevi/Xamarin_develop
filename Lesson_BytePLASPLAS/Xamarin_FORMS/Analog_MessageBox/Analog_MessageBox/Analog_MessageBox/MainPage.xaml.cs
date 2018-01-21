using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Analog_MessageBox
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private async  void Button1_click(object sendler,EventArgs e)
        {
            // await  DisplayAlert("Pop up", "Пример Xamarin всплывающее окно", "OK");        --------простое всплывающее окно

            //всплывающее окно с выбором 
          bool result=  await DisplayAlert("Выбор действия", "Перекрасить фон в синий?","Да","Нет");
            if(result)
            {
                stackP.BackgroundColor = Color.FromHex("7c4DFF");
            }
            else
            {
                await DisplayAlert("", "Действие отменено", "OK");
            }
        }
    }

}
