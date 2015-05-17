using System;
using System.Collections.Generic;

using Android.Widget;
using Android.Content;
using Android.Views;

using iPark.Entities;

namespace iPark.Droid
{
	public class ParksListViewAdapter : BaseAdapter<Park>
	{
		private List<Park> _items;
		private Context _context;

		public ParksListViewAdapter (Context context, List<Park> items)
		{
			_items = items;
			_context = context;
		}

		public override int Count 
		{
			get { return _items.Count; }
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override Park this[int index] 
		{
			get { return _items[index]; }
		}

		public override Android.Views.View GetView (int position, View convertView, ViewGroup parent)
		{
			View row = convertView;

			if (row == null) 
			{
				row = LayoutInflater.From (_context).Inflate (Resource.Layout.ParksListView_row, null, false);
			}

			TextView textName = row.FindViewById<TextView> (Resource.Id.textName);
			textName.Text = _items [position].Name;

			TextView textCompany = row.FindViewById<TextView> (Resource.Id.textCompany);
			textCompany.Text = _items [position].Company;

			TextView textTimetable = row.FindViewById<TextView> (Resource.Id.textTimetable);
			textTimetable.Text = String.Format("Aberto das {0} até às {1}", _items [position].OpeningHour, _items [position].ClosingHour);

			TextView textPrice = row.FindViewById<TextView> (Resource.Id.textPrice);
			textPrice.Text = String.Format("Preço por hora: {0}", _items [position].PricePerHour.ToString());

			return row;
		}
	}
}

