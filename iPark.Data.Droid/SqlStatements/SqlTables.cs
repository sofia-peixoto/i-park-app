using System;
using System.Text;

namespace iPark.Data
{
	public static class SqlTables
	{
		public static string Users
		{
			get 
			{ 
				StringBuilder sbSql = new StringBuilder ();

				sbSql.Append ("CREATE TABLE [Users]");
				sbSql.Append ("(");
				sbSql.Append ("ID integer PRIMARY KEY ASC,");
				sbSql.Append ("Username varchar(20) ,");
				sbSql.Append ("Password varchar(20) ,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Email varchar(200),");
				sbSql.Append ("Gender char(1),");
				sbSql.Append ("Country varchar(100),");
				sbSql.Append ("Age integer,");
				sbSql.Append ("RegistrationDate date");
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
				sbSql.Append ("(");
				sbSql.Append ("ID integer PRIMARY KEY ASC,");
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
				sbSql.Append ("PricePerHour decimal(11,8),");
				sbSql.Append ("Floors integer,");
				sbSql.Append ("DisabledPlaces integer,");
				sbSql.Append ("Capacity integer");
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
				sbSql.Append ("(");
				sbSql.Append ("ID integer PRIMARY KEY ASC,");
				sbSql.Append ("ParkID integer,");
				sbSql.Append ("Description varchar(100)");
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
				sbSql.Append ("(");
				sbSql.Append ("ID integer PRIMARY KEY ASC,");
				sbSql.Append ("Latitude decimal(11,8),");
				sbSql.Append ("Longitude decimal(11,8)");
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
				sbSql.Append ("(");
				sbSql.Append ("ID integer PRIMARY KEY ASC,");
				sbSql.Append ("Name varchar(100),");
				sbSql.Append ("Value varchar(200)");
				sbSql.Append (");");

				return sbSql.ToString ();
			}
		}
	}
}

