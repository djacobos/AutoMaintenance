using System;
using SQLite;

namespace AutoMaintenance
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();
	}
}

