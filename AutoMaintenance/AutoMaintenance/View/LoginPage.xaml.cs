using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

		public void OnClick_Login(object o, EventArgs e)
		{
			Navigation.PushAsync (new DashboardPage());
		}
	}
}

