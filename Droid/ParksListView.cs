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
	public class ParksListView : ActionBarActivity
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
			listviewParks.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				int ID = (int)listviewParks.GetItemIdAtPosition(e.Position);
				var newActivity = new Intent (this, typeof(ParksSingleView));
				newActivity.PutExtra ("MyData", mItems[ID].Id.ToString());
				StartActivity (newActivity);
			};

			buttonParksMapView.Click += buttonParksMapView_Click;

			InicializeListView ();
		}

		private void buttonParksMapView_Click(object sender, EventArgs e)
		{
			base.OnBackPressed ();
		}

		private void InicializeListView()
		{
			mItems = Services.loadParks ();

			//ArrayAdapter<string> adapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1, mItems);
			ParksListViewAdapter adapter = new ParksListViewAdapter(this, mItems);

			listviewParks.Adapter = adapter;
		}
	}
}