package mvvmcross.binding.droid.views;


public class MvxSimpleListItemView
	extends mvvmcross.binding.droid.views.MvxListItemView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MvvmCross.Binding.Droid.Views.MvxSimpleListItemView, MvvmCross.Binding.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", MvxSimpleListItemView.class, __md_methods);
	}


	public MvxSimpleListItemView () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MvxSimpleListItemView.class)
			mono.android.TypeManager.Activate ("MvvmCross.Binding.Droid.Views.MvxSimpleListItemView, MvvmCross.Binding.Droid, Version=5.2.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
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
