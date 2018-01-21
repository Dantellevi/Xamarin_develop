using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Menu_ToolBar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ToolbarItem tb = new ToolbarItem {
                Text="Позвонить",       //текст тулбара
                Order=ToolbarItemOrder.Primary,     //Получает или задает значение, указывающее, на какой из основных, вторичных или стандартных панелей инструментов отображать этотэлемент ToolbarItem 
                Priority=0,     //Получает или задает приоритет этогоэлемента
                Icon=new FileImageSource
                {
                    File= "iconPhone.png"
                }

            };

            tb.Clicked += async (s, e) =>
              {
                  await DisplayAlert("Вызов", "Идет набор номера", "сбросить");

              };

            ToolbarItem tb1 = new ToolbarItem
            {
                Text = "Новый контакт",       //текст тулбара
                Order = ToolbarItemOrder.Secondary,     //Получает или задает значение, указывающее, на какой из основных, вторичных или стандартных панелей инструментов отображать этотэлемент ToolbarItem 
                Priority = 1,     //Получает или задает приоритет этогоэлемента
               

            };

            ToolbarItem tb2 = new ToolbarItem
            {
                Text = "Удалить",       //текст тулбара
                Order = ToolbarItemOrder.Secondary,     //Получает или задает значение, указывающее, на какой из основных, вторичных или стандартных панелей инструментов отображать этотэлемент ToolbarItem 
                Priority = 2,     //Получает или задает приоритет этогоэлемента


            };

            ToolbarItem tb3 = new ToolbarItem
            {
                Text = "О программе",       //текст тулбара
                Order = ToolbarItemOrder.Secondary,     //Получает или задает значение, указывающее, на какой из основных, вторичных или стандартных панелей инструментов отображать этотэлемент ToolbarItem 
                Priority = 3,     //Получает или задает приоритет этогоэлемента


            };



            ToolbarItems.Add(tb);       //добавляем наш тулбар на экран
            ToolbarItems.Add(tb1);       //добавляем наш тулбар на экран
            ToolbarItems.Add(tb2);       //добавляем наш тулбар на экран
            ToolbarItems.Add(tb3);       //добавляем наш тулбар на экран

        }
    }
}
