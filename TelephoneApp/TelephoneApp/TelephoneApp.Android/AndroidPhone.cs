﻿using Android.Content;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;


[assembly: Dependency(typeof(TelephoneApp.Droid.AndroidPhone))]
namespace TelephoneApp.Droid
{
    
    public class AndroidPhone : IPhone
    {
        public Task Call(string phoneNumber)
        {
            var packageManager = Android.App.Application.Context.PackageManager;
            Android.Net.Uri telUri = Android.Net.Uri.Parse($"tel:{phoneNumber}");
            var callIntent = new Intent(Intent.ActionCall, telUri);     //установка связи и настройка соединения

            callIntent.AddFlags(ActivityFlags.NewTask);
            // проверяем доступность
            var result = null != callIntent.ResolveActivity(packageManager);

            if (!string.IsNullOrWhiteSpace(phoneNumber) && result == true)
            {
                Android.App.Application.Context.StartActivity(callIntent);
            }

            return Task.FromResult(true);
        }
    }
}