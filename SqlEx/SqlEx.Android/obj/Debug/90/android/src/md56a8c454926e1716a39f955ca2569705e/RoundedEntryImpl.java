package md56a8c454926e1716a39f955ca2569705e;


public class RoundedEntryImpl
	extends md51558244f76c53b6aeda52c8a337f2c37.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("SqlEx.Droid.RoundedEntryImpl, SqlEx.Android", RoundedEntryImpl.class, __md_methods);
	}


	public RoundedEntryImpl (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == RoundedEntryImpl.class)
			mono.android.TypeManager.Activate ("SqlEx.Droid.RoundedEntryImpl, SqlEx.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public RoundedEntryImpl (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RoundedEntryImpl.class)
			mono.android.TypeManager.Activate ("SqlEx.Droid.RoundedEntryImpl, SqlEx.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public RoundedEntryImpl (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RoundedEntryImpl.class)
			mono.android.TypeManager.Activate ("SqlEx.Droid.RoundedEntryImpl, SqlEx.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
