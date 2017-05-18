using System;
using SQLite;

namespace AutoMaintenance
{
	public class Maintenance
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set;}
		public DateTime CreatedOn { get; set;}
		public string Vehicle {get;set;}
		public string Notes {get;set;}
		public DateTime NextDate {get;set;}
		public double Amount {get;set;}
		public MaintenanceType MaintenanceType  {get;set;}
	}
}

