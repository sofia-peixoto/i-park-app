using System;

using Mono.Data.Sqlite;
using System.IO;
using System.Data;

namespace iPark
{
	public class Database
	{
		static object locker = new object ();
		private SqliteConnection connection;
		private string path;

		public Database (string dbPath)
		{
			path = dbPath;

			// create the tables
			if (!File.Exists (path)) 
			{
				CreateDatabase ();
			}
		}

		#region Create
		/// <summary>
		/// Creates the database.
		/// </summary>
		private void CreateDatabase()
		{
			try 
			{
				connection = new SqliteConnection ("Data Source=" + path);
				connection.Open ();

				var commands = new String[] 
				{
					SqlTables.Users,
					SqlTables.Parks,
					SqlTables.PaymentMethods,
					SqlTables.Localizations,
					SqlTables.Settings
				};

				foreach (var command in commands) 
				{
					using (var c = connection.CreateCommand ()) 
					{
						c.CommandText = command;
						var i = c.ExecuteNonQuery ();
					}
				}
			} catch (Exception ex) 
			{
				throw new DataException (ex.Message);
			}
		}
		#endregion
	}
}


