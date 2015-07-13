using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

using iPark.Entities;
using iPark.Core.Business;

namespace iPark.Droid
{
	[Activity (Label = "MyParker", Icon = "@drawable/MyParker_icon", Theme="@style/MyTheme")]			
	public class ParksSingleView : ActionBarActivity
	{
		Park thePark = null;
		Button goToLocation;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView(Resource.Layout.ParksSingleView);

			string parkStringId = Intent.GetStringExtra("MyData") ?? "Data not available";
			int parkId = int.Parse (parkStringId);
			foreach (Park parque in Services.activeParks) {
				if (parque.Id == parkId) {
					thePark = parque;
					break;
				}
			}
			if (thePark == null)
				Toast.MakeText (this, "Houve um erro com o programa. Pedimos que o reinicie manualmente..", ToastLength.Long).Show ();
			else {
				PopulateInfo ();
				Toast.MakeText (this, String.Format("geo:{0},{1}", thePark.Latitude, thePark.Longitude), ToastLength.Long).Show ();
			}

			goToLocation = FindViewById<Button> (Resource.Id.button1);
			goToLocation.Click += GoToLocation;
		}

		private void PopulateInfo() {
			TextView textName = FindViewById<TextView> (Resource.Id.textName);
			TextView textCompany = FindViewById<TextView> (Resource.Id.textCompany);
			TextView textTimetable = FindViewById<TextView> (Resource.Id.textTimetable);
			TextView textStockingRate = FindViewById<TextView> (Resource.Id.textStockingRate);
			TextView textPrice = FindViewById<TextView> (Resource.Id.textPrice);
			TextView textFloors = FindViewById<TextView> (Resource.Id.textFloors);
			TextView textPhone = FindViewById<TextView> (Resource.Id.textPhone);

			textName.Text = thePark.Name;
			textCompany.Text = thePark.Company;
			textTimetable.Text = String.Format(Resources.GetString(Resource.String.ParkData_Timetable), thePark.OpeningHour, thePark.ClosingHour);
			textStockingRate.Text = String.Format((thePark.StockingRate*100).ToString() + "% of empty spaces");
			textPrice.Text = String.Format(Resources.GetString(Resource.String.ParkData_Price), thePark.PricePerHour.ToString());
			textFloors.Text = String.Format(thePark.Floors.ToString() + " floors");
			textPhone.Text = String.Format ("Contact: " + thePark.Phone);
		}

		private void GoToLocation(object sender, EventArgs e) {
			var geoUri = Android.Net.Uri.Parse (String.Format("geo:{0},{1}", thePark.Latitude, thePark.Longitude));
			var mapIntent = new Intent (Intent.ActionView, geoUri);
			StartActivity (mapIntent);
		}
	}
}