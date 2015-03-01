using System;

namespace iPark
{
	public class Park
	{
		public Park ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Company { get; set; }
		public string Address { get; set; }
		public string ZIPCode { get; set; }
		public string Country { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }
		public string Phone { get; set; }
		public string OpeningHour { get; set; }
		public string ClosingHour { get; set; }
		public string PricePerHour { get; set; }
		public string Floors { get; set; }
		public string DisabledSpaces { get; set; }
		public string Capacity { get; set; }
		public string Stocking { get; set; }
		public string StockingRate { get; set; }
	}
}

