using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AutoMaintenance
{
	public partial class DashboardPage : TabbedPage
	{
		public DashboardPage (MaintenanceRepository database)
		{
			InitializeComponent ();
			this.Children.Add (new OilChangePage (database));
			this.Children.Add (new TagChangePage (database));
			this.Children.Add (new TireChangePage (database));
		}
	}
}

