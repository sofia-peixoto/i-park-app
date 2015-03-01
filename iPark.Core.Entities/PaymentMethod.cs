using System;

namespace iPark
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

