using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger_Styles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            //==================Работа с триггерами из кода =================
            Entry entry = new Entry();

            //определяем триггер для элемента 
            var trigger = new Trigger(typeof(Entry))
            {
                Property=Entry.IsFocusedProperty,
                Value=true
            };

            trigger.Setters.Add(new Setter
            {
                Property=Entry.BackgroundColorProperty,
                Value=Color.Green
            });

            // установка белого цвета текста
            trigger.Setters.Add(new Setter
            {
                Property = Entry.TextColorProperty,
                Value = Color.White
            });
            //хранит действия, которые применяются при срабатывании триггера
            trigger.EnterActions.Add(new FocusTriggerAction());
            //хранит действия, которые выполняются, когда триггер перестает действовать
            trigger.ExitActions.Add(new FocusTriggerAction());
            // добавляем триггер
            entry.Triggers.Add(trigger);

            Content = new StackLayout
            {
                Children = { entry }
            };
        }


        
    }
}
