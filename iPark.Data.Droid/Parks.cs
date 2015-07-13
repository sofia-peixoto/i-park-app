using System;
using System.Linq;
using System.Collections.Generic;
//using System.IO;
using System.Data;

using Mono.Data.Sqlite;

using iPark.Entities;

namespace iPark.Data
{
	public class Parks
	{
		static object locker = new object ();
		private SqliteConnection connection;

		public Parks(SqliteConnection connection)
		{
			this.connection = connection;
		}

		/// <summary>
		/// Convert from DataReader to Park entitie.
		/// </summary>
		/// <returns>Park entitie.</returns>
		/// <param name="r">The reader component.</param>
		Park FromReader (SqliteDataReader r) 
		{
			var t = new Park ();

			t.Id = Convert.ToInt32 (r ["Id"]);
			t.Name = r ["Name"].ToString ();
			t.Company = r ["Company"].ToString ();
			t.Address = r ["Address"].ToString ();
			t.ZIPCode = r ["Name"].ToString ();
			t.Country = r ["Country"].ToString ();
			t.Latitude = Convert.ToDouble (r ["Latitude"]);
			t.Longitude = Convert.ToDouble (r ["Longitude"]);
			t.Phone = r ["Phone"].ToString ();
			t.OpeningHour = r ["OpeningHour"].ToString ();
			t.ClosingHour = r ["ClosingHour"].ToString ();
			t.PricePerHour = Convert.ToDouble (r ["PricePerHour"]);
			t.Floors = Convert.ToInt32 (r ["Floors"]);
			t.DisabledSpaces = Convert.ToInt32 (r ["DisabledSpaces"]);
			t.Capacity = Convert.ToInt32 (r ["Capacity"]);
			t.Stocking = Convert.ToDouble (r ["Stocking"]);
			t.StockingRate = Convert.ToDouble (r ["StockingRate"]);

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

