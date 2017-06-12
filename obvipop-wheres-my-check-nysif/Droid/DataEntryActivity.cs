
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
using Android.Content;


namespace wheres.my.check.nysif.Droid
{
    [Activity(Label = "DataEntryActivity")]
    public class DataEntryActivity : Activity
    {
        private int state = 0;
        ImageView imgSettingsButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.find_checks);
            imgSettingsButton = (ImageView)FindViewById(Resource.Id.imageView7);


            imgSettingsButton.Click += methodInvokeAlertDialogWithListView;
            /*    delegate
			{
                if(state % 2 == 0){
                    imgSettingsButton.SetImageResource(Resource.Drawable.settings_icon_active);
                    //(new Intent(Application.Context, typeof(AboutActivity)));
                }
                else {
                    imgSettingsButton.SetImageResource(Resource.Drawable.settings_icon);
                }
                state++;
			};*/
			Button findCheckButton = (Button)FindViewById(Resource.Id.button3);
			findCheckButton.Click += delegate
			{
                StartActivity(new Intent(Application.Context, typeof(DataEntryScreenSingleRowActivity)));
			};
        }

		void methodInvokeAlertDialogWithListView(object sender, EventArgs e)
		{

			if (state % 2 == 0)
			{
				imgSettingsButton.SetImageResource(Resource.Drawable.settings_icon_active);
			}
			else
			{
				imgSettingsButton.SetImageResource(Resource.Drawable.settings_icon);
			}
			state++;

			var dlgAlert = (new AlertDialog.Builder(this)).Create();
			dlgAlert.SetTitle("Settings");
			var listView = new ListView(this);

            List<String> _lstDataItem = new List<String>();
			_lstDataItem.Add("Log out");
			_lstDataItem.Add("About");

			listView.Adapter = new AlertListViewAdapter(this, _lstDataItem);
			listView.ItemClick += listViewItemClick;
			dlgAlert.SetView(listView);
			//dlgAlert.SetButton(0, "OK", handllerNotingButton);

			dlgAlert.Show();
		}

		void listViewItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
            //Toast.MakeText(this, "you clicked on ", ToastLength.Short).Show();
            if(e.Position == 0){
                StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
            }
            else{
                StartActivity(new Intent(Application.Context, typeof(AboutActivity)));
            }
		}

		internal class AlertListViewAdapter : BaseAdapter<string>
		{
			Activity _context = null;
			List<String> _lstDataItem = null;

			public AlertListViewAdapter(Activity context, List<String> lstDataItem)
			{
                
				_context = context;
				_lstDataItem = lstDataItem;
			}

			#region implemented abstract members of BaseAdapter

			public override long GetItemId(int position)
			{
				return position;
			}

			public override View GetView(int position, View convertView, ViewGroup parent)
			{
				if (convertView == null)
					convertView = _context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1, null);

				(convertView.FindViewById<TextView>(Android.Resource.Id.Text1))
					.SetText(this[position], TextView.BufferType.Normal);

				return convertView;
			}

			public override int Count
			{
				get
				{
					return _lstDataItem.Count;
				}
			}

			#endregion

			#region implemented abstract members of BaseAdapter

			public override string this[int index]
			{
				get
				{
					return _lstDataItem[index];
				}
			}

			#endregion

		}
    }
}
