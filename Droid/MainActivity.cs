﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

using iPark.Data;
using Xamarin.Forms.Platform.Android;

namespace iPark.Droid
{
	[Activity (Label = "MyParker", Icon = "@drawable/MyParker_icon", MainLauncher = true, Theme="@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : ActionBarActivity
	{
		AutoCompleteTextView autoCompleteTextViewUsername;
		EditText editTextPassword;

		TextView textViewRecoverPassword;
		TextView textViewRegister;
		TextView textViewAnonymous;

		Button buttonLogin;
		Button buttonLoginFacebook;
		Button buttonLoginGoogle;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.Main);

			autoCompleteTextViewUsername = FindViewById<AutoCompleteTextView>(Resource.Id.editTextUsername);
			editTextPassword = FindViewById<EditText>(Resource.Id.editTextPassword);

			textViewRecoverPassword = FindViewById<TextView>(Resource.Id.textViewPasswordRecover);
			textViewRegister = FindViewById<TextView>(Resource.Id.textViewRegister);
			textViewAnonymous = FindViewById<TextView>(Resource.Id.textViewAnonymous);

			buttonLogin = FindViewById<Button>(Resource.Id.buttonLogin);
			buttonLoginFacebook = FindViewById<Button>(Resource.Id.buttonLoginFacebook);
			buttonLoginGoogle = FindViewById<Button>(Resource.Id.buttonLoginGoogle);

			buttonLogin.Click += buttonLogin_Click;
			buttonLoginFacebook.Click += buttonLoginFacebook_Click;
			buttonLoginGoogle.Click += buttonLoginGoogle_Click;
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			StartActivity(typeof(ParksMapView));
		}

		private void buttonLoginFacebook_Click(object sender, EventArgs e)
		{

		}

		private void buttonLoginGoogle_Click(object sender, EventArgs e)
		{

		}
	}

}

