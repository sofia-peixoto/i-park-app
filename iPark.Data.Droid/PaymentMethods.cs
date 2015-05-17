using System;
using System.Linq;
using System.Collections.Generic;
//using System.IO;
using System.Data;

using Mono.Data.Sqlite;

using iPark.Entities;

namespace iPark.Data
{
	public class PaymentMethods
	{
		static object locker = new object ();
		private SqliteConnection connection;

		/// <summary>
		/// Initializes a new instance of the <see cref="iPark.Data.PaymentMethods"/> class.
		/// </summary>
		/// <param name="connection">Connection.</param>
		public PaymentMethods(SqliteConnection connection)
		{
			this.connection = connection;
		}

		/// <summary>
		/// Convert from DataReader to PaymentMethod entitie.
		/// </summary>
		/// <returns>PaymentMethod entitie.</returns>
		/// <param name="r">The reader component.</param>
		PaymentMethod FromReader (SqliteDataReader r) 
		{
			var t = new PaymentMethod ();

			t.Id = Convert.ToInt32 (r ["Id"]);
			t.ParkId = Convert.ToInt32 (r ["ParkId"]);
			t.Description = r ["Description"].ToString ();

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

