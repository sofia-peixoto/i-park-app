using System;
using iPark.Entities;
using System.Collections.Generic;

namespace iPark.Core.Business
{
	public class Services
	{
		static List<Park> mItems;

		public Services ()
		{
			
		}

		public static List<Park> loadParks(){
			mItems = new List<Park> ();

			mItems.Add(new Park() {Id = 0, Name = "Parque da Estação", Latitude = 41.5496534, Longitude = -8.4336081, Company = "SIENT - Sistemas de Engenharia de Trânsito", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7,
				StockingRate = 0.6, Capacity = 100, DisabledSpaces = 60});
			mItems.Add(new Park() {Id = 1, Name = "St André", Latitude = 41.5525837, Longitude = -8.4226206, Company = "José Gomes & Filhos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7,
				StockingRate = 0.7, Capacity = 200, DisabledSpaces = 140});
			mItems.Add(new Park() {Id = 2, Name = "São Vicente", Latitude = 41.5496534, Longitude = -8.4170409, Company = "SM Parque-Sociedade Exploradora de Aparcamentos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7,
				StockingRate = 0.8, Capacity = 150, DisabledSpaces = 120});
			mItems.Add(new Park() {Id = 3, Name = "São João do Souto", Latitude = 41.5471102, Longitude = -8.4218102, Company = "Granjiparque-Sociedade Parques Estacionamento Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7,
				StockingRate = 0.9, Capacity = 250, DisabledSpaces = 225});
			ParkGroup UM = new ParkGroup () {Id = 4, Name = "Universidade do Minho - Gualtar", Latitude = 41.560758, Longitude = -8.397521, Company = "Universidade do Minho", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.6,
				StockingRate = 0.65, Capacity = 600, DisabledSpaces = 390};
			UM.addPark (new Park () {Id = 5, Name = "Parque 1", Latitude = 41.561843, Longitude = -8.398156, StockingRate = 0.9, Capacity = 50});
			UM.addPark (new Park () {Id = 6, Name = "Parque 2", Latitude = 41.561753, Longitude = -8.397813, StockingRate = 0.8, Capacity = 50});
			UM.addPark (new Park () {Id = 7, Name = "Parque 3", Latitude = 41.561900, Longitude = -8.396243, StockingRate = 0.4, Capacity = 50});
			UM.addPark (new Park () {Id = 8, Name = "Parque 4", Latitude = 41.562375, Longitude = -8.395457, StockingRate = 0.5, Capacity = 70});
			UM.addPark (new Park () {Id = 9, Name = "Parque 5", Latitude = 41.561234, Longitude = -8.394776, StockingRate = 0.6, Capacity = 70});
			UM.addPark (new Park () {Id = 10, Name = "Parque 6", Latitude = 41.560785, Longitude = -8.394572, StockingRate = 0.7, Capacity = 50});
			UM.addPark (new Park () {Id = 11, Name = "Parque 7", Latitude = 41.559921, Longitude = -8.400892, StockingRate = 0.8, Capacity = 70});
			UM.addPark (new Park () {Id = 12, Name = "Parque 8", Latitude = 41.559408, Longitude = -8.400823, StockingRate = 0.6, Capacity = 70});
			UM.addPark (new Park () {Id = 13, Name = "Parque 9", Latitude = 41.559172, Longitude = -8.397578, StockingRate = 0.9, Capacity = 50});
			UM.addPark (new Park () {Id = 14, Name = "Parque 10", Latitude = 41.559648, Longitude = -8.396621, StockingRate = 0.6, Capacity = 50});
			mItems.Add((Park)UM);
			
/*			mItems.Add(new Park() {Id = 5, Name = "St André", Latitude = 41.5525837, Longitude = -8.4226206, Company = "José Gomes & Filhos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 6, Name = "São Vicente", Latitude = 41.5496534, Longitude = -8.4170409, Company = "SM Parque-Sociedade Exploradora de Aparcamentos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 7, Name = "São João do Souto", Latitude = 41.5471102, Longitude = -8.4218102, Company = "Granjiparque-Sociedade Parques Estacionamento Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 8, Name = "Parque da Estação", Latitude = 41.5496534, Longitude = -8.4336081, Company = "SIENT - Sistemas de Engenharia de Trânsito", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 9, Name = "St André", Latitude = 41.5525837, Longitude = -8.4226206, Company = "José Gomes & Filhos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 10, Name = "São Vicente", Latitude = 41.5496534, Longitude = -8.4170409, Company = "SM Parque-Sociedade Exploradora de Aparcamentos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 11, Name = "São João do Souto", Latitude = 41.5471102, Longitude = -8.4218102, Company = "Granjiparque-Sociedade Parques Estacionamento Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 12, Name = "Parque da Estação", Latitude = 41.5496534, Longitude = -8.4336081, Company = "SIENT - Sistemas de Engenharia de Trânsito", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 13, Name = "St André", Latitude = 41.5525837, Longitude = -8.4226206, Company = "José Gomes & Filhos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 14, Name = "São Vicente", Latitude = 41.5496534, Longitude = -8.4170409, Company = "SM Parque-Sociedade Exploradora de Aparcamentos Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
			mItems.Add(new Park() {Id = 15, Name = "São João do Souto", Latitude = 41.5471102, Longitude = -8.4218102, Company = "Granjiparque-Sociedade Parques Estacionamento Lda", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7});
*/
			return mItems;
		}

		public static Park getPark(int ID) {
			foreach (var item in mItems) {
				if (item.Id == ID)
					return item;
			}
			return null;
		}

		public static string getName(int ID){
			foreach (Park park in mItems) {
				if (park.Id == ID)
					return park.Name;
			}
			return null;
		}

		public static string getCompany(int ID){
			foreach (Park park in mItems) {
				if (park.Id == ID)
					return park.Company;
			}
			return null;
		}

		public static string getEmptySpaces(int ID){
			foreach (Park park in mItems) {
				if (park.Id == ID)
					return (park.Capacity - park.DisabledSpaces).ToString();
			}
			return null;
		}

		public static string getSpaces(int ID){
			foreach (Park park in mItems) {
				if (park.Id == ID)
					return park.Capacity.ToString();
			}
			return null;
		}

		public static string getPricePerHour(int ID){
			foreach (Park park in mItems) {
				if (park.Id == ID)
					return park.PricePerHour.ToString();
			}
			return null;
		}

		public static List<Park> activeParks {
			set { mItems = value; }
			get { return mItems; }
		}
	}
}