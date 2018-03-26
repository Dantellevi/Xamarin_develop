using System;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.Media;

namespace CameraApp.Droid
{
	[Activity (Label = "CameraApp", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override async void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);
            await CrossMedia.Current.Initialize();
			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new CameraApp.App ());
		}
	}
}

