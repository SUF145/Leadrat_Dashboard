package crc6426126fc9ed8a1cca;


public abstract class MvxFormsSplashScreenActivity_3
	extends mvvmcross.platforms.android.views.MvxSplashScreenActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Forms.Platforms.Android.Views.MvxFormsSplashScreenActivity`3, MvvmCross.Forms", MvxFormsSplashScreenActivity_3.class, __md_methods);
	}


	public MvxFormsSplashScreenActivity_3 ()
	{
		super ();
		if (getClass () == MvxFormsSplashScreenActivity_3.class) {
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Platforms.Android.Views.MvxFormsSplashScreenActivity`3, MvvmCross.Forms", "", this, new java.lang.Object[] {  });
		}
	}


	public MvxFormsSplashScreenActivity_3 (int p0)
	{
		super (p0);
		if (getClass () == MvxFormsSplashScreenActivity_3.class) {
			mono.android.TypeManager.Activate ("MvvmCross.Forms.Platforms.Android.Views.MvxFormsSplashScreenActivity`3, MvvmCross.Forms", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
		}
	}

	private java.util.ArrayList refList;
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
