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
using Android.Locations;
using Android.Gms.Maps;
using Android.Support.V7.App;
using Android.Gms.Maps.Model;
using iPark.Entities;
using iPark.Core.Business;

namespace iPark.Droid
{
	[Activity (Label = "MyParker", Icon = "@drawable/MyParker_icon", Theme="@style/MyTheme")]
	public class ParksMapView : ActionBarActivity, IOnMapReadyCallback, ILocationListener, GoogleMap.IOnMarkerClickListener
	{
		LocationManager locMgr;
		Location actualLoc;

		GoogleMap theMap;
		Button buttonParksListView;
		Android.Gms.Maps.Model.LatLng lastLocation = null;
		bool isInsideMarker = false;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.ParksMapView);

			buttonParksListView = FindViewById<Button>(Resource.Id.buttonParksListView);
			SetUpMap ();

			buttonParksListView.Click += buttonParksListView_Click;

			//Location services
			locMgr = GetSystemService (Context.LocationService) as LocationManager;
			Services.loadParks ();
		}

		private void buttonParksListView_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(ParksListView));
			/*var newActivity = new Intent (this, typeof(ParksSingleView));
			newActivity.PutExtra ("MyData", mItems[0].Id.ToString());
			StartActivity (newActivity);*/
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			string provider = LocationManager.GpsProvider;

			if(locMgr.IsProviderEnabled(provider))
			{
				locMgr.RequestLocationUpdates (provider, 4000, 1, this);
				//Log.Info(tag, Provider + " is not available. Does the device have location services enabled?");
			}
			else
			{
				Criteria locationCriteria = new Criteria();

				locationCriteria.Accuracy = Accuracy.Medium;
				locationCriteria.PowerRequirement = Power.Low;

				provider = locMgr.GetBestProvider(locationCriteria, true);

				if(provider != null)
				{
					locMgr.RequestLocationUpdates (provider, 2000, 1, this);
				}
				else
				{
					//Log.Info(tag, "No location providers available");
				}
			}
		}

		protected override void OnPause ()
		{
			base.OnPause ();
			locMgr.RemoveUpdates (this);
		}


		//ILocationListener
		public void OnProviderEnabled (string provider)
		{

		}
		public void OnProviderDisabled (string provider)
		{

		}
		public void OnStatusChanged (string provider, Availability status, Bundle extras)
		{

		}
		public void OnLocationChanged (Android.Locations.Location location) {
			/*actualLoc = location;
			if (theMap != null) {
				CameraPosition.Builder builder = CameraPosition.InvokeBuilder ()
					.Target (new Android.Gms.Maps.Model.LatLng (
							location.Latitude,
							location.Longitude))
					.Bearing (location.Bearing);
				
				theMap.MoveCamera (CameraUpdateFactory.NewCameraPosition (builder.Build ()));
			}*/
		}

		//Map
		private void SetUpMap() {
			if (theMap == null) {
				FragmentManager.FindFragmentById<MapFragment> (Resource.Id.map).GetMapAsync(this);
			}
		}

		public void OnMapReady (GoogleMap googleMap) {
			theMap = googleMap;

			theMap.InfoWindowClick += onInfoWindowClicked;
			theMap.SetOnMarkerClickListener(this);
			theMap.SetInfoWindowAdapter (new parkInfoWindowAdapter(LayoutInflater));
			theMap.UiSettings.ZoomControlsEnabled = true;
			theMap.UiSettings.TiltGesturesEnabled = false;
			theMap.UiSettings.CompassEnabled = true;
			theMap.MyLocationEnabled = true;
			theMap.TrafficEnabled = true;
			theMap.MapLongClick += (object sender, GoogleMap.MapLongClickEventArgs e) => {
				actualLoc = theMap.MyLocation;
		};

			ResetMap ();
		}

		private void ResetMap() {
			//Select map type
			theMap.MapType = GoogleMap.MapTypeNormal;
			//allow user movement
			theMap.UiSettings.SetAllGesturesEnabled(true);
			theMap.UiSettings.MyLocationButtonEnabled = true;

			//Position the camera
			CameraPosition.Builder builder = CameraPosition.InvokeBuilder ();
			builder.Zoom (15);
			builder.Tilt (25);

			if (lastLocation == null) {
				builder.Target (new Android.Gms.Maps.Model.LatLng (
					41.5514942,-8.4209417));
			} else {
				builder.Target (lastLocation);
			}

			theMap.AnimateCamera (CameraUpdateFactory.NewCameraPosition (builder.Build ()));

			//Mark parks
			theMap.Clear();
			MarkParks ();
		}

		private void MarkParks () {
			foreach (Park parque in Services.activeParks) {
				MarkerOptions markerOpt1 = new MarkerOptions();
				markerOpt1.SetPosition(new LatLng(parque.Latitude, parque.Longitude));
				markerOpt1.SetTitle(parque.Id.ToString());
				if (parque.StockingRate < 0.70) {
					markerOpt1.InvokeIcon (BitmapDescriptorFactory.DefaultMarker (BitmapDescriptorFactory.HueGreen));
				} else if (parque.StockingRate < 0.90) {
					markerOpt1.InvokeIcon (BitmapDescriptorFactory.DefaultMarker (BitmapDescriptorFactory.HueYellow));
				} else {
					markerOpt1.InvokeIcon (BitmapDescriptorFactory.DefaultMarker (BitmapDescriptorFactory.HueRed));
				}

				theMap.AddMarker(markerOpt1);
			}
		}

		private void onInfoWindowClicked (object sender, GoogleMap.InfoWindowClickEventArgs e) {
			Marker myMarker = e.Marker;

			try {
				ParkGroup park = (ParkGroup) Services.getPark(int.Parse(myMarker.Title));
				foreach (Park item in park.Parques) {
					Console.WriteLine(item.Name);
				}
				theMap.UiSettings.SetAllGesturesEnabled(false);
				CameraPosition.Builder builder = CameraPosition.InvokeBuilder ();
				builder.Target (myMarker.Position);
				builder.Zoom (17.2f);

				theMap.AnimateCamera (CameraUpdateFactory.NewCameraPosition (builder.Build ()));
				theMap.Clear();
				theMap.MapType = GoogleMap.MapTypeSatellite;
				theMap.UiSettings.MyLocationButtonEnabled = false;
				Services.activeParks = park.Parques;
				MarkParks();
				isInsideMarker = true;
			}
			catch (Exception ex) {
				var newActivity = new Intent (this, typeof(ParksSingleView));
				newActivity.PutExtra ("MyData", myMarker.Title);
				StartActivity (newActivity);
			}
		}

		public override void OnBackPressed () {
			if (isInsideMarker) {
				Services.loadParks ();
				ResetMap ();
			} else
				base.OnBackPressed ();

			isInsideMarker = false;
		}

		Marker lastOpenned = null;
		public bool OnMarkerClick (Marker marker)
		{
			// Check if there is an open info window
			if (lastOpenned != null) {
				// Close the info window
				lastOpenned.HideInfoWindow();

				// Is the marker the same marker that was already open
				if (lastOpenned.Equals(marker)) {
					// Nullify the lastOpened object
					lastOpenned = null;
					// Return so that the info window isn't opened again
					return true;
				} 
			}

			// Open the info window for the marker
			marker.ShowInfoWindow();
			// Re-assign the last opened such that we can close it later
			lastOpenned = marker;

			// Event was handled by our code do not launch default behaviour.
			return true;
		}
	}
}