using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RenderingElements
{
  public  class HeaderView : View
    {

        public event EventHandler TappedOrClickEvent;
        public void FireClick(EventArgs e)
        {
            if (this.TappedOrClickEvent != null)
                this.TappedOrClickEvent(this, e);
        }


        public static readonly BindableProperty TextProperty =
           BindableProperty.Create("Text", typeof(string), typeof(HeaderView), string.Empty);
        public string Text
        {
            set
            {
                SetValue(TextProperty, value);
            }
            get
            {
                return (string)GetValue(TextProperty);
            }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create("TextColor", typeof(Color), typeof(HeaderView), Color.Default);
        public Color TextColor
        {
            set
            {
                SetValue(TextColorProperty, value);
            }
            get
            {
                return (Color)GetValue(TextColorProperty);
            }
        }
    }
}
