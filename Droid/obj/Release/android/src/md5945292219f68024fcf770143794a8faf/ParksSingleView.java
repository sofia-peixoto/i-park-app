package md5945292219f68024fcf770143794a8faf;


public class ParksSingleView
	extends android.support.v7.app.ActionBarActivity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("iPark.Droid.ParksSingleView, iPark.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ParksSingleView.class, __md_methods);
	}


	public ParksSingleView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ParksSingleView.class)
			mono.android.TypeManager.Activate ("iPark.Droid.ParksSingleView, iPark.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
