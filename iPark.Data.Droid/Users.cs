using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using Mono.Data.Sqlite;
using iPark.Entities;

namespace iPark.Data
{
	public class Users
	{
		//static object locker = new object ();
		//private SqliteConnection connection;
		private Database database;

		public Users()
		{
			database = new Database ();
		}

		/// <summary>
		/// Convert from DataReader to User entitie.
		/// </summary>
		/// <returns>User entitie.</returns>
		/// <param name="r">The reader component.</param>
		User FromReader (SqliteDataReader r) 
		{
			var t = new User ();

			t.Id = Convert.ToInt32 (r ["Id"]);
			t.Username = r ["Username"].ToString ();
			t.Password = r ["Password"].ToString ();
			t.Name = r ["Name"].ToString();
			t.Email = r ["Email"].ToString();
			t.Gender = r ["Gender"].ToString();
			t.Country = r ["Country"].ToString();
			t.Age = Convert.ToInt32 (r ["Age"]);
			t.RegistrationDate = Convert.ToDateTime (r ["RegistrationDate"]);
			t.fbId = r ["fbId"].ToString();
			t.ggId = r ["ggId"].ToString();

			//t.Age = Convert.ToInt32 (r ["Done"]) == 1 ? true : false;

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

