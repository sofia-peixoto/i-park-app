using System;

namespace iPark.Entities
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
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }
		public string Phone { get; set; }
		public string OpeningHour { get; set; }
		public string ClosingHour { get; set; }
		public decimal PricePerHour { get; set; }
		public int Floors { get; set; }
		public int DisabledSpaces { get; set; }
		public int Capacity { get; set; }
		public decimal Stocking { get; set; }
		public decimal StockingRate { get; set; }
	}
}

