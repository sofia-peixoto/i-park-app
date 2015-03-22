using System;

namespace iPark.Entities
{
	public class Localization
	{
		public Localization ()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Latitude { get; set; }
		public decimal Longitude { get; set; }

	}
}

