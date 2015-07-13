using System;
using Android.Gms.Maps;
using Android.Views;
using Android.Content;
using Android.Widget;
using iPark.Entities;
using iPark.Core.Business;

namespace iPark.Droid
{
	public class parkInfoWindowAdapter : Java.Lang.Object, GoogleMap.IInfoWindowAdapter
	{
		LayoutInflater inflater;
		public parkInfoWindowAdapter (LayoutInflater inflater) :base()
		{
			this.inflater = inflater;
		}

		#region IInfoWindowAdapter implementation

		public Android.Views.View GetInfoContents (Android.Gms.Maps.Model.Marker marker)
		{
			View v = inflater.Inflate (Resource.Layout.ParksListView_row, null);

			TextView textName = v.FindViewById<TextView> (Resource.Id.textName);
			textName.Text = Services.getName(int.Parse(marker.Title));

			TextView textCompany = v.FindViewById<TextView> (Resource.Id.textCompany);
			textCompany.Text = Services.getCompany(int.Parse(marker.Title));

			TextView textTimetable = v.FindViewById<TextView> (Resource.Id.textTimetable);
			textTimetable.Text = (Services.getPark(int.Parse(marker.Title)).StockingRate*100).ToString() + "% of empty spaces"; //String.Format(context.Resources.GetString(Resource.String.ParkData_Timetable), "7h", "19h");

			TextView textPrice = v.FindViewById<TextView> (Resource.Id.textPrice);
			textPrice.Text = Services.getPricePerHour(int.Parse(marker.Title)) + " € per hour"; //String.Format(context.Resources.GetString(Resource.String.ParkData_Price), "6$");

			return v;
		}

		public Android.Views.View GetInfoWindow (Android.Gms.Maps.Model.Marker marker)
		{
			return null;
		}

		#endregion
	}
}