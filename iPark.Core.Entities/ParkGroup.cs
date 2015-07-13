using System;
using System.Collections.Generic;
using iPark.Entities;

namespace iPark.Entities
{
	public class ParkGroup : Park
	{
		private List<Park> mItems = null;

		public ParkGroup () :base() {
			mItems = new List<Park> ();
		}

		public void addPark(Park newPark) {
			mItems.Add (newPark);

			newPark.Company = this.Company;
			newPark.Country = this.Country;
			newPark.PricePerHour = this.PricePerHour;
			newPark.OpeningHour = this.OpeningHour;
			newPark.ClosingHour = this.ClosingHour;

			this.Capacity += newPark.Capacity;
			this.DisabledSpaces += newPark.DisabledSpaces;
			this.Stocking += newPark.Stocking;

			this.StockingRate = 0;
			foreach (Park park in mItems) {
				this.StockingRate += park.StockingRate;
			}
			this.StockingRate /= mItems.Count;
		}

		public List<Park> Parques {
			get { return mItems; }
		}
	}
}