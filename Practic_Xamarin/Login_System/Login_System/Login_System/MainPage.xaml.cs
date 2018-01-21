using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Login_System
{
    public partial class MainPage : ContentPage
    {

        List<string> Names;     //список пользователей
        List<string> passwords; //пороли пользователей
        string nameUser;
        string passworduser;
        public MainPage()
        {
            InitializeComponent();

            Names = new List<string>()
            {
                "Александр",
                "Павел",
                "Виктор"
            };

            passwords = new List<string>()
            {
                "12345",
                "4815162342",
                "1157150"
            };



        }


        private async void but_ok_click(object sendler,EventArgs e)
        {
            nameUser="";
            passworduser="";
            bool Nameflag = false;
            bool Passwordflag = false;
            //=============================Проверка по спискам имен и поролей=================
            for (int i=0;i<Names.Count;i++)
            {
                if(Entry_nameUser.Text==Names[i])
                {
                    nameUser = Entry_nameUser.Text;
                    Nameflag = true;
                    break;
                }
                else
                {
                    Nameflag = false;
                }
            }

            for(int i=0;i<passwords.Count; i++)
            {
                if(Entry_passwordUser.Text == passwords[i])
                {
                    passworduser = Entry_passwordUser.Text;
                    Passwordflag = true;
                    break;
                }
                else
                {
                    Passwordflag = false;
                }
            }

            if(Nameflag==true && Passwordflag==true)
            {
                await DisplayAlert("Авторизация", "Пользователь с именем " + nameUser + " и поролем: " + passworduser + " Авторизировался", "OK");
            }
            else
            {
                await DisplayAlert("Авторизация", "Ошибка!!!Неверные имя или пороль!!!!!", "OK");
            }
            //================================================================================
        }

        private async void but_Cancel_click(object sendler,EventArgs e)
        {
            //==========================Очистка всех полей=====================
            Entry_nameUser.Text="";
            Entry_passwordUser.Text = "";
            nameUser = "";
            passworduser = "";
            await DisplayAlert("Авторизация", "Поля очищены. Попробуйте еще раз!!!", "OK");
            //=================================================================
        }


    }
}
