
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

namespace iPark.Droid
{
	[Activity (Label = "MyParker", Icon = "@drawable/icon")]
	public class ParksMapView : Activity
	{
		Button buttonParksListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.ParksMapView);

			buttonParksListView = FindViewById<Button>(Resource.Id.buttonParksListView);

			buttonParksListView.Click += buttonParksListView_Click;
		}

		private void buttonParksListView_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(ParksListView));
		}
	}
}

