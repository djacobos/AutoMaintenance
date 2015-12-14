﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace AutoMaintenance.Droid
{
	[Activity (Label = "AutoMaintenance.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
			FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;
			LoadApplication (new App ());
		}
	}
}
