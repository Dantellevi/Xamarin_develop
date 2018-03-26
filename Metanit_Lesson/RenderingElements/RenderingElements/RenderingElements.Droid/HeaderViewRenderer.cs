using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using RenderingElements;
using RenderingElements.Droid;

[assembly: ExportRenderer(typeof(HeaderView), typeof(HeaderViewRenderer))]
namespace RenderingElements.Droid
{
   public class HeaderViewRenderer: ViewRenderer<HeaderView, TextView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HeaderView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                // создаем и настраиваем элемент
                TextView textView = new TextView(Context);
                textView.SetTextSize(ComplexUnitType.Dip, 28);

                // устанавливаем элемент для класса из Portable-проекта
                SetNativeControl(textView);
                // установка свойств
                if (args.NewElement != null)
                {
                    SetText();
                    SetTextColor();
                }
            }
        }

        // изменения свойства
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == HeaderView.TextColorProperty.PropertyName)
            {
                SetTextColor();
            }
            else if (e.PropertyName == HeaderView.TextProperty.PropertyName)
            {
                SetText();
            }
        }
        private void SetText()
        {
            Control.Text = Element.Text;
        }
        private void SetTextColor()
        {
            Android.Graphics.Color andrColor = Android.Graphics.Color.Gray;

            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                andrColor = Android.Graphics.Color.Argb(
                    (byte)(color.A * 255),
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255));
            }
            Control.SetTextColor(andrColor);
        }
    }
}