using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger_Styles
{
    /// <summary>
    /// Класс для реализации триггера действий
    /// </summary>
    class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {

            /*
             * В данном случае мы будем ожидать ввод только цифр в поле Entry. 
             * Если же будут введены нецифровые символы,
             *  то поле окрасится в красный цвет.
             * */
            int number;
            if (!Int32.TryParse(sender.Text, out number))
                sender.BackgroundColor = Color.Red;
            else
                sender.BackgroundColor = Color.Default;
        }
    }
}
