package md5945292219f68024fcf770143794a8faf;


public class parkInfoWindowAdapter
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.InfoWindowAdapter
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_getInfoContents:(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;:GetGetInfoContents_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, GooglePlayServicesLib\n" +
			"n_getInfoWindow:(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;:GetGetInfoWindow_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, GooglePlayServicesLib\n" +
			"";
		mono.android.Runtime.register ("iPark.Droid.parkInfoWindowAdapter, iPark.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", parkInfoWindowAdapter.class, __md_methods);
	}


	public parkInfoWindowAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == parkInfoWindowAdapter.class)
			mono.android.TypeManager.Activate ("iPark.Droid.parkInfoWindowAdapter, iPark.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public parkInfoWindowAdapter (android.view.LayoutInflater p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == parkInfoWindowAdapter.class)
			mono.android.TypeManager.Activate ("iPark.Droid.parkInfoWindowAdapter, iPark.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.LayoutInflater, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getInfoContents (com.google.android.gms.maps.model.Marker p0)
	{
		return n_getInfoContents (p0);
	}

	private native android.view.View n_getInfoContents (com.google.android.gms.maps.model.Marker p0);


	public android.view.View getInfoWindow (com.google.android.gms.maps.model.Marker p0)
	{
		return n_getInfoWindow (p0);
	}

	private native android.view.View n_getInfoWindow (com.google.android.gms.maps.model.Marker p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
