using System;
using Foundation;
using UIKit;
using Xamarin.Forms;
using System.Threading.Tasks;


[assembly:Dependency(typeof(TelephoneApp.iOS.IOSPhone))]
namespace TelephoneApp.iOS
{
    public class IOSPhone : IPhone
    {
        public Task Call(string phoneNumber)
        {
            var nsurl = new NSUrl(new Uri($"tel:{phoneNumber}").AbsoluteUri);
            if (!string.IsNullOrWhiteSpace(phoneNumber) &&
                    UIApplication.SharedApplication.CanOpenUrl(nsurl))
            {
                UIApplication.SharedApplication.OpenUrl(nsurl);
            }
            return Task.FromResult(true);
        }
    }
}
