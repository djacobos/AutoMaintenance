using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class OilChangePage : ContentPage
	{
		private MaintenanceRepository _database;
		private ListView _listView;

		public OilChangePage (MaintenanceRepository database)
		{
			InitializeComponent ();
			_database = database;
			this.BindingContext = _database;//new OilChangeViewModel ();

		}

		public void OnClick_AddOilChange(object o, EventArgs e)
		{
			Navigation.PushAsync (new AddOilChangePage (this, _database));
		}

		public void Refresh() {
			_listView.ItemsSource = _database.GetMaintenanceAll ();
		}
	}
}

