using System;

namespace iPark.Entities
{
	public class PaymentMethod
	{
		public PaymentMethod ()
		{
		}

		public int Id { get; set; }
		public int ParkId { get; set; }
		public string Description { get; set; }
	}
}

