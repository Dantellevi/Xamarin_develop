using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger_Styles
{

    /// <summary>
    /// Класс для реализации действий в триггере
    /// </summary>
    class FocusTriggerAction : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            /*
             * В метод Invoke в качестве параметра передается элемент Entry, 
             * к которому применяется триггер. В методе Invoke проверяем, 
             * имеет ли текстовое поле фокус, и если имеет, то делаем его 
             * непрозрачным, иначе делаем его наполовину прозрачным.
             * */
            if (sender.IsFocused)
                sender.FadeTo(1);
            else
                sender.FadeTo(0.5);
        }
    }
}
