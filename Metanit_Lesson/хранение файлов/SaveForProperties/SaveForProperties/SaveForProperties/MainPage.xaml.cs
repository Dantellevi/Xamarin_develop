using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SaveForProperties
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*
             * Добавление данных в словарь:
             * App.Current.Properties.Add("name", "Tom");
                // или так
                App.Current.Properties["name"] = "Tom";
                --------------------------------------------------------------------
                Получение значения:
                string name = App.Current.Properties["name"];
                --------------------------------------------------------------------
                Получение с проверкой:
                object name = "";
                if(App.Current.Properties.TryGetValue("name", out name))
                {
                    // выполняем действия, если в словаре есть ключ "name"
                }
                --------------------------------------------------------------------
                Удаление
                App.Current.Properties.Remove("name");

             * 
             * */
        }



        protected override void OnAppearing()
        {
            object name = "";       //создаем переменню для временного хранения данных
            if(App.Current.Properties.TryGetValue("name",out name)) //проверяем имеются ли данных по указанному ключу и сохраняем в name
            {
                nameBox.Text = (string)name;    //запсываем в текстбокс
            }

            base.OnAppearing();
        }


        private void btn_click(object sendler,EventArgs e)
        {
            btn.BackgroundColor = Color.Blue;
            
            string value = nameBox.Text;    //переносим данные с текстбокса
            App.Current.Properties["name"] = value; //заносим данные с текстбокса в словарь и сохраняем их

        }
    }
}
