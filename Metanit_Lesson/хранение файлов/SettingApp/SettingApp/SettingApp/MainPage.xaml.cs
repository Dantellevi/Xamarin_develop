using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Settings;
namespace SettingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*
             * // сохраняем значение Tom по ключу name
                CrossSettings.Current.AddOrUpdateValue<string>("name", "Tom");
                -------------------------------------------------------------------
                Получение сохраненного значения по ключу:
                string name = CrossSettings.Current.GetValueOrDefault<string>("name");
                // если объекта нет используем значение по умолчанию - "не известно"
                string name2 = CrossSettings.Current.GetValueOrDefault<string>("name", "не известно");
                -------------------------------------------------------------------
                Удаление:
                CrossSettings.Current.Remove("name");
             * */
        }

        protected override void OnAppearing()
        {
            string name = CrossSettings.Current.GetValueOrDefault("name", "отсутствует");
            nameBox.Text = name;
            base.OnAppearing();
        }



        private void OnClick(object sender, EventArgs e)
        {
            string value = nameBox.Text;
            CrossSettings.Current.AddOrUpdateValue("name", value);
        }



    }
}
