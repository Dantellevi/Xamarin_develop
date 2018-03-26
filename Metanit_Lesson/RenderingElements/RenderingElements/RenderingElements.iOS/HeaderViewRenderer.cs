using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using RenderingElements;
using RenderingElements.iOS;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(HeaderView), typeof(HeaderViewRenderer))]
namespace RenderingElements.iOS
{
   public class HeaderViewRenderer: ViewRenderer<HeaderView, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<HeaderView> args)
        {
            base.OnElementChanged(args);
            if (Control == null)
            {
                UILabel uilabel = new UILabel
                {
                    Font = UIFont.SystemFontOfSize(25)
                };
                SetNativeControl(uilabel);
            }
            if (args.NewElement != null)
            {
                SetText();
                SetTextColor();
            }
        }

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
            UIColor iosColor = UIColor.Gray;

            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                iosColor = UIColor.FromRGBA(
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255),
                    (byte)(color.A * 255));
            }
            Control.TextColor = iosColor;
        }



    }
}
