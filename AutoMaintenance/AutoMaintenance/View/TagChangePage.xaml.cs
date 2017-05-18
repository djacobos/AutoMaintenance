using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class TagChangePage : ContentPage
	{
		private MaintenanceRepository _database;
		public TagChangePage (MaintenanceRepository database)
		{
			InitializeComponent ();
			_database = database;
			this.BindingContext = _database;//new OilChangeViewModel ();

		}
	}
}

