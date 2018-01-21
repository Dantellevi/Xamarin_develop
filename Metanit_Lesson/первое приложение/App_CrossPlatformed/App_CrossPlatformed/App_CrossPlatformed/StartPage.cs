using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_CrossPlatformed
{

    /*
     * Данный класс представляет страницу, 
     * поэтому наследуется от класса ContentPage. В конструкторе 
     * создается метка с текстом, которая задается в качестве 
     * содержимого страницы (this.Content = header).
     * */
    class StartPage :ContentPage
    {
        public StartPage()
        {
            Label header = new Label() { Text = "Привет Андроид!!!!" };
            this.Content = header;

        }
    }
}
