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
			bool userPassCombination = true;

			if (userName.Text != "david")
				userPassCombination = false;

			if (password.Text != "david")
				userPassCombination = false;

			if (userPassCombination) {
				Navigation.PushAsync (new DashboardPage());
			}


			// Notify user of invalid credentials
			errorMessage.Text = "Error: Invalid credentials, try again.";
		}

		public void OnClick_Register(object o, EventArgs e)
		{
			Navigation.PushAsync (new RegisterPage());
		}
	}
}

