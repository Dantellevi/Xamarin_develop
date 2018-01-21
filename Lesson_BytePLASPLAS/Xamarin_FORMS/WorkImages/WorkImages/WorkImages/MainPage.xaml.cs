using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Reflection;
using System.IO;

namespace WorkImages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            //==============================задание источника с помощью статического ресурса===========
            //Image1.Source = ImageSource.FromResource("WorkImages.women.jpg");       //указываем источник
            //Image1.Aspect = Aspect.Fill;        //указваем растяжение
            //-=========================================================================================

            //====================================задание источника с помощью потока=====================
            //Image1.Source = ImageSource.FromStream(() =>
            //{
            //    Assembly assambly = GetType().GetTypeInfo().Assembly;

            //    Stream stream = assambly.GetManifestResourceStream("WorkImages.women.jpg");
            //    return stream;
            //});

            //============================================================================================


            //=========================================загрузка изображения из Интернета================
            //Image1.Source = ImageSource.FromUri(new Uri("http://bipbap.ru/pictures/smeshnye-kartinki-na-avatarku-35-foto.html"));
            //==========================================================================================



            //=========================================загрузка изображения из Интернета кэширование================
            //Image1.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://www.google.by/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwiqm4ahk9fYAhWKDpoKHQMlAAMQjRwIBw&url=https%3A%2F%2Fok.ru%2Fbellesphotos&psig=AOvVaw0TKtiwVjN1B-lQm3Vj95_y&ust=1516008865551723"),

            //    CachingEnabled=true,        //разрешаем кеширование
            //    CacheValidity=new TimeSpan(0,1,0)       //время жизни кеша 1 мин в данном случае

            //};
            //==========================================================================================


            //===========================================Загрузка изображения из папки с ресурсами================
            Image1.Source = ImageSource.FromFile("women.jpg");

            //====================================================================================================


        }
    }
}
