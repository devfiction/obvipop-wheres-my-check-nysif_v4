package md535ce57b2a3973e2674d4015e56d9064b;


public class DataEntryScreenSingleRowActivity_MyAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("wheres.my.check.nysif.Droid.DataEntryScreenSingleRowActivity+MyAdapter, wheres.my.check.nysif.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DataEntryScreenSingleRowActivity_MyAdapter.class, __md_methods);
	}


	public DataEntryScreenSingleRowActivity_MyAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataEntryScreenSingleRowActivity_MyAdapter.class)
			mono.android.TypeManager.Activate ("wheres.my.check.nysif.Droid.DataEntryScreenSingleRowActivity+MyAdapter, wheres.my.check.nysif.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public DataEntryScreenSingleRowActivity_MyAdapter (android.content.Context p0, int p1, int p2) throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataEntryScreenSingleRowActivity_MyAdapter.class)
			mono.android.TypeManager.Activate ("wheres.my.check.nysif.Droid.DataEntryScreenSingleRowActivity+MyAdapter, wheres.my.check.nysif.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
