using System;
using System.Text;

namespace iPark
{
	public static class SqlTables
	{
		public static string Users
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [User]");
				sbSql.Append (");");
				sbSql.Append ("ID int INTEGER PRIMARY KEY ASC,");
				sbSql.Append ("Username varchar(20) ,");
				sbSql.Append ("Password varchar(20) ,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Email varchar(200),");
				sbSql.Append ("Gender char(1),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Age int(11),");
				sbSql.Append ("RegistrationDate date,");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}

		public static string Parks
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [Parks]");
				sbSql.Append (");");
				sbSql.Append ("ID int INTEGER PRIMARY KEY ASC,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Company varchar(100),");
				sbSql.Append ("Address varchar(250),");
				sbSql.Append ("ZIPCode varchar(10),");
				sbSql.Append ("ZIPLocation varchar(80),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Latitude decimal(11,8),");
				sbSql.Append ("Longitude decimal(11,8),");
				sbSql.Append ("Phone varchar(20),");
				sbSql.Append ("OpeningHour varchar(5),");
				sbSql.Append ("ClosingHour varchar(5),");
				sbSql.Append ("PricePerHour int(11),");
				sbSql.Append ("Floors int(11),");
				sbSql.Append ("DisabledPlaces int(11),");
				sbSql.Append ("Capacity int(11),");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}

		public static string PaymentMethods
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [PaymentMethods]");
				sbSql.Append (");");
				sbSql.Append ("ID int INTEGER PRIMARY KEY ASC,");
				sbSql.Append ("Username varchar(20) ,");
				sbSql.Append ("Password varchar(20) ,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Email varchar(200),");
				sbSql.Append ("Gender char(1),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Age int(11),");
				sbSql.Append ("RegistrationDate date,");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}

		public static string Localizations
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [Localizations]");
				sbSql.Append (");");
				sbSql.Append ("ID int INTEGER PRIMARY KEY ASC,");
				sbSql.Append ("Username varchar(20) ,");
				sbSql.Append ("Password varchar(20) ,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Email varchar(200),");
				sbSql.Append ("Gender char(1),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Age int(11),");
				sbSql.Append ("RegistrationDate date,");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}

		public static string Settings
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [Settings]");
				sbSql.Append (");");
				sbSql.Append ("ID int INTEGER PRIMARY KEY ASC,");
				sbSql.Append ("Username varchar(20) ,");
				sbSql.Append ("Password varchar(20) ,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Email varchar(200),");
				sbSql.Append ("Gender char(1),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Age int(11),");
				sbSql.Append ("RegistrationDate date,");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}
	}
}

