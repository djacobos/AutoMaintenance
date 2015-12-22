using System;
using SQLite;

namespace AutoMaintenance
{
	public class User
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set;}
		public DateTime CreatedOn { get; set;}
		public string FirstName {get;set;}
		public string LastName {get;set;}
		public string UserName {get;set;}
		public string Password {get;set;}
	}
}

