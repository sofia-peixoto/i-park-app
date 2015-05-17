using System;
using System.Linq;
using System.Collections.Generic;
//using System.IO;
using System.Data;

using Mono.Data.Sqlite;

using iPark.Entities;

namespace iPark.Data
{
	public class Localizations
	{
		static object locker = new object ();
		private SqliteConnection connection;

		public Localizations(SqliteConnection connection)
		{
			this.connection = connection;
		}

		/// <summary>
		/// Convert from DataReader to Localization entitie.
		/// </summary>
		/// <returns>Localization entitie.</returns>
		/// <param name="r">The reader component.</param>
		Localization FromReader (SqliteDataReader r) 
		{
			var t = new Localization ();

			t.Id = Convert.ToInt32 (r ["Id"]);
			t.Name = r ["Name"].ToString ();
			t.Latitude = Convert.ToDecimal (r ["Latitude"]);
			t.Longitude = Convert.ToDecimal (r ["Longitude"]);

			return t;
		}

//		public User GetItem (int id) 
//		{
//			var t = new User ();
//			lock (locker) {
//				connection = new SqliteConnection ("Data Source=" + path);
//				connection.Open ();
//				using (var command = connection.CreateCommand ()) {
//					command.CommandText = "SELECT [_id], [Name], [Notes], [Done] from [Items] WHERE [_id] = ?";
//					command.Parameters.Add (new SqliteParameter (DbType.Int32) { Value = id });
//					var r = command.ExecuteReader ();
//					while (r.Read ()) {
//						t = FromReader (r);
//						break;
//					}
//				}
//				connection.Close ();
//			}
//			return t;
//		}	
	}
}

