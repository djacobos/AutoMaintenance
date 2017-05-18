using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class AddOilChangePage : ContentPage
	{
		private OilChangePage _parent;
		private MaintenanceRepository _database;

		public AddOilChangePage ( OilChangePage parent, MaintenanceRepository database)
		{
			_parent = parent;
			_database = database;
			Title = "Enter a description";

			var entry = new Entry ();
			var button = new Button {
				Text = "Add"
			};

			button.Clicked += async (object sender, EventArgs e) => {
				var thought = entry.Text;

				_database.AddMaintenance("Nissan", "My new oil", DateTime.Now, 99.99, MaintenanceType.OilChange);

				await Navigation.PopAsync();


				_parent.Refresh();
			};

			Content = new StackLayout {
				Spacing = 20,
				Padding = new Thickness(20),
				Children = { entry, button },
			};
		}
	}
}

