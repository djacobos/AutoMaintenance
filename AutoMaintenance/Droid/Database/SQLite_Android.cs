using System;
using Xamarin.Forms;
using AutoMaintenance.Droid;
using System.IO;
using SQLite;

[assembly: Dependency (typeof(SQLite_Android))]
namespace AutoMaintenance.Droid
{
	public class SQLite_Android : ISQLite
	{
		#region ISQLite implementation

		public SQLiteConnection GetConnection ()
		{
			var sqliteFilename = "AutoMaintenance.db3";
			var documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath, sqliteFilename);

			var connection = new SQLiteConnection (path);

			return connection;
		}

		#endregion
	}
}

