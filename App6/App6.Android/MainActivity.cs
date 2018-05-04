using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
namespace App6.Droid
{
	[Activity (Label = "App6", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            AppCenter.Start("f37460cc-6a34-4b46-9dcb-9e65ba4b19a8",
                   typeof(Analytics), typeof(Crashes));
            AppCenter.Start("f37460cc-6a34-4b46-9dcb-9e65ba4b19a8", typeof(Analytics), typeof(Crashes));
            AppCenter.Start("f37460cc-6a34-4b46-9dcb-9e65ba4b19a8", typeof(Distribute));

            TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			LoadApplication (new App6.App ());
		}
	}
}

