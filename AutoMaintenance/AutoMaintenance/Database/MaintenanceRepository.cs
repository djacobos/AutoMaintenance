using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;

namespace AutoMaintenance
{
	public class MaintenanceRepository
	{
		private SQLiteConnection _connection;

		public MaintenanceRepository ()
		{
			_connection = DependencyService.Get<ISQLite> ().GetConnection ();
			_connection.CreateTable<Maintenance> ();
			_connection.CreateTable<User> ();
		}

		public IEnumerable<Maintenance> GetMaintenanceAll() 
		{
			IEnumerable<Maintenance> results;
			results = (from t in _connection.Table<Maintenance> ()
			           select t).ToList ();

			return results;

		}

		public Maintenance GetMaintenance(int id) {
			return _connection.Table<Maintenance> ().FirstOrDefault (t => t.ID == id);
		}

		public void DeleteMaintenance(int id) {
			_connection.Delete<Maintenance> (id);
		}

		public void AddMaintenance(string vehicle, string notes, DateTime nextDate, double amount, MaintenanceType type) {
			var newThought = new Maintenance {
				CreatedOn = DateTime.Now,
				Vehicle = vehicle,
				Notes = notes,
				NextDate = nextDate,
				Amount = amount,
				MaintenanceType  = type
			};

			_connection.Insert (newThought);
		}
	}
}

