using System;

namespace iPark.Entities
{
	public class Park
	{
		public Park ()
		{
			Country = "Portugal";
			OpeningHour = "0:00";
			ClosingHour = "24:00";
			PricePerHour = 0;
			Floors = 1;
			DisabledSpaces = 0;
			Capacity = 0;
			Stocking = 0;
			StockingRate = 0;
			Phone = "+351 253 012 345";
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Company { get; set; }
		public string Address { get; set; }
		public string ZIPCode { get; set; }
		public string Country { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }
		public string Phone { get; set; }
		public string OpeningHour { get; set; }
		public string ClosingHour { get; set; }
		public double PricePerHour { get; set; }
		public int Floors { get; set; }
		public int DisabledSpaces { get; set; }
		public int Capacity { get; set; }
		public double Stocking { get; set; }
		public double StockingRate { get; set; }
	}
}