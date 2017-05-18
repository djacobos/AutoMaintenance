using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class TireChangePage : ContentPage
	{
		private MaintenanceRepository _database;
		public TireChangePage (MaintenanceRepository database)
		{
			InitializeComponent ();
			_database = database;
			this.BindingContext = _database;//new OilChangeViewModel ();

		}
	}
}

