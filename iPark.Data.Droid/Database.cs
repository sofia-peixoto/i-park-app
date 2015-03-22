using System;

using Mono.Data.Sqlite;
using System.IO;
using System.Data;

using iPark.Entities;

namespace iPark.Data
{
	public class Database
	{
		// Sql connection
		private SqliteConnection connection;

//		// Entitie classes
//		private Users users;
//		private Localizations localizations;
//		private Parks parks;
//		private PaymentMethods paymentMethods;

		/// <summary>
		/// Initializes a new instance of the <see cref="iPark.Data.Database"/> class.
		/// </summary>
		/// <param name="dbPath">Database path</param>
		public Database ()
		{
			string dbPath = DatabaseFilePath;
			File.Delete (dbPath);

			if (!File.Exists (dbPath)) 
			{
				// create the tables
				CreateDatabase (dbPath);
			}
		}

		/// <summary>
		/// Creates the database.
		/// </summary>
		private void CreateDatabase(string dbPath)
		{
			try 
			{
				connection = new SqliteConnection ("Data Source=" + dbPath);
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

		private static string DatabaseFilePath 
		{
			get 
			{ 
				var sqliteFilename = "MyParkerDB.db3";
				#if NETFX_CORE

				var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, sqliteFilename);
				#else

				#if SILVERLIGHT
				// Windows Phone expects a local path, not absolute
				var path = sqliteFilename;
				#else

				#if __ANDROID__
				// Just use whatever directory SpecialFolder.Personal returns
				string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); ;
				#else
				// we need to put in /Library/ on iOS5.1 to meet Apple's iCloud terms
				// (they don't want non-user-generated data in Documents)
				string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal); // Documents folder
				string libraryPath = Path.Combine (documentsPath, "..", "Library"); // Library folder
				#endif

				var path = Path.Combine (libraryPath, sqliteFilename);

				#endif

				#endif

				return path;	
			}
		}

		/// <summary>
		//		/// Gets the users class.
		//		/// </summary>
		//		/// <value>The users class.</value>
		//		public Users Users 
		//		{ 
		//			get 
		//			{ 
		//				if (connection == null) {
		//					throw new DataException ("Database not initialized.");
		//				}
		//
		//				if (users == null) {
		//					users = new Users (this.connection);
		//				}
		//
		//				return users;
		//			}
		//		}
		//
		//		/// <summary>
		//		/// Gets the localizations.
		//		/// </summary>
		//		/// <value>The localizations class.</value>
		//		public Localizations Localizations
		//		{ 
		//			get 
		//			{ 
		//				if (connection == null) {
		//					throw new DataException ("Database not initialized.");
		//				}
		//
		//				if (localizations == null) {
		//					localizations = new Localizations(this.connection);
		//				}
		//
		//				return localizations;
		//			}
		//		}
		//
		//		/// <summary>
		//		/// Gets the parks class.
		//		/// </summary>
		//		/// <value>The parks class.</value>
		//		public Parks Parks 
		//		{ 
		//			get 
		//			{ 
		//				if (connection == null) {
		//					throw new DataException ("Database not initialized.");
		//				}
		//
		//				if (parks == null) {
		//					parks = new Parks (this.connection);
		//				}
		//
		//				return parks;
		//			}
		//		}
		//
		//		/// <summary>
		//		/// Gets the payment methods class.
		//		/// </summary>
		//		/// <value>The payment methods class.</value>
		//		public PaymentMethods PaymentMethods 
		//		{ 
		//			get 
		//			{ 
		//				if (connection == null) {
		//					throw new DataException ("Database not initialized.");
		//				}
		//
		//				if (paymentMethods == null) {
		//					paymentMethods = new PaymentMethods (this.connection);
		//				}
		//
		//				return paymentMethods;
		//			}
		//		}
	}
}


