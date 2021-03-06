﻿using Foundation;
using Microsoft.Identity.Client;
using UIKit;

namespace TodoAzure.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
			LoadApplication(new App());

			var result = base.FinishedLaunching(app, options);
			App.AuthenticationProvider.Initialize(new PlatformParameters(UIApplication.SharedApplication.KeyWindow.RootViewController));
			return result;
		}
	}
}
