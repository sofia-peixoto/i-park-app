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

using iPark.Entities;

namespace iPark.Droid
{
	[Activity (Label = "MyParker")]			
	public class ParksListView : Activity
	{
		Button buttonParksMapView;
		ListView listviewParks;

		List<Park> mItems;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.ParksListView);

			buttonParksMapView = FindViewById<Button>(Resource.Id.buttonParksMapView);
			listviewParks = FindViewById<ListView>(Resource.Id.listviewParks);

			buttonParksMapView.Click += buttonParksMapView_Click;

			InicializeListView ();
		}

		private void buttonParksMapView_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(ParksMapView));
		}

		private void InicializeListView()
		{
			mItems = new List<Park> ();

			mItems.Add(new Park() {Name = "Parque 1", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 2", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 3", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 4", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 5", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 6", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 7", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});
			mItems.Add(new Park() {Name = "Parque 8", Company = "Braga Parques", OpeningHour = "7:00", ClosingHour = "24:00", PricePerHour = 0.7M});

			//ArrayAdapter<string> adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, mItems);
			ParksListViewAdapter adapter = new ParksListViewAdapter(this, mItems);

			listviewParks.Adapter = adapter;
		}
	}


}

