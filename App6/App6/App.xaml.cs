using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AppCenter.Distribute;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace App6
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new App6.MainPage();
		}

		protected override void OnStart ()
		{
            AppCenter.Start("android=f37460cc-6a34-4b46-9dcb-9e65ba4b19a8;" +
                  "uwp={Your UWP App secret here};" +
                  "ios={Your iOS App secret here}",
                  typeof(Analytics), typeof(Crashes));

            AppCenter.Start("ios={Your Xamarin iOS App Secret};android=f37460cc-6a34-4b46-9dcb-9e65ba4b19a8;", typeof(Distribute));
            // Handle when your app starts
        }

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
