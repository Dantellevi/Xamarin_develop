using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace First_App_CSharp
{
    public class Page1 : ContentPage
    {

        //Создание разметки из C# кода
        Entry Entry1;
        Button Button1;
        Label Labl;
        public Page1()
        {
             Entry1 = new Entry
            {
                Placeholder = "Поле для ввода",
                TextColor=Color.Lime
            };

             Button1 = new Button
            {
                Text="Нажми меня"

            };
            Button1.FontAttributes = FontAttributes.Bold;

            Button1.Clicked += Button1_Clicked;

             Labl = new Label();
            Labl.FontSize = 27;

            Content = new StackLayout()
            {
                Children = { Entry1, Button1, Labl }
            };

            //либо так:
            /*
             * StackLayout stackLayout = new StackLayout();
             * stackLayout.Children.Add( Entry1);
             * stackLayout.Children.Add( Button1);
             * stackLayout.Children.Add( Labl);
             * Content=stackLayout;
             * */
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Labl.Text = Entry1.Text;
        }
    }
}
