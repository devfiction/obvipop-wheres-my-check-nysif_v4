
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;

namespace wheres.my.check.nysif.Droid
{
    [Activity(Label = "DataEntryScreenSingleRowActivity")]
    public class DataEntryScreenSingleRowActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.check_results);

			var metrics = Resources.DisplayMetrics;

			var widthInDp = metrics.WidthPixels;
			var heightInDp = metrics.HeightPixels;
            GridView gv = (GridView)FindViewById(Resource.Id.gridview);
            gv.Adapter = new MyAdapter(this, widthInDp, heightInDp);

			GridView gv1 = (GridView)FindViewById(Resource.Id.gridview1);
			gv1.Adapter = new MyAdapter1(this, widthInDp, heightInDp);

            Button backButton = (Button)FindViewById(Resource.Id.buttonBack);
			backButton.Click += delegate
			{
				StartActivity(new Intent(Application.Context, typeof(DataEntryActivity)));
			};
        }


        public class MyAdapter1 : BaseAdapter
        {
            private readonly Context context;
            private readonly string[] thumbIds = {
                "Check Dated",
                "Amount Paid",
                "Paid to Date",
                "EFT or Check",
                "05/27/2016",
                "658.40",
                "03/18/2015",
                "EFT",
				"03/16/2016",
				"658.40",
				"03/04/2015",
				"EFT",
				"07/21/2015",
				"658.40",
				"02/18/2015",
				"Check",
				"01/30/2015",
				"658.40",
				"02/04/2015",
				"EFT",
				"01/15/2015",
				"658.40",
				"01/21/2015",
				"EFT",
				"01/02/2015",
				"658.40",
				"01/07/2015",
				"Check",
				"01/02/2015",
				"658.40",
				"01/07/2015",
				"EFT",
				"01/02/2015",
				"658.40",
				"01/07/2015",
				"EFT",
				"01/02/2015",
				"658.40",
				"01/07/2015",
				"EFT",
				"01/02/2015",
				"658.40",
				"01/07/2015",
				"EFT"
            };
            int width, height;

            public MyAdapter1(Context c, int _width, int _height)
            {
                context = c;
                width = _width;
                height = _height;

            }

            public override int Count
            {
                get { return thumbIds.Length; }
            }

            public override Java.Lang.Object GetItem(int position)
            {
                throw new NotImplementedException();
            }

            public override long GetItemId(int position)
            {
                return 0;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                TextView textView;

                if (convertView == null)
                {
                    // if it's not recycled, initialize some attributes
                    textView = new TextView(context);

                    textView.LayoutParameters = new LinearLayout.LayoutParams(width / 4, height / 15);
                    textView.Gravity = GravityFlags.Center;

					var shape = new ShapeDrawable(new RectShape());
                    shape.Paint.Color = Color.White;
					shape.Paint.StrokeWidth = 1;
					shape.Paint.SetStyle(Paint.Style.Stroke);
                    textView.SetPadding(0, 5, 0, 5);
					textView.SetBackgroundDrawable(shape);
                }
                else
                {
                    textView = (TextView)convertView;
                }
                //textView.SetText(thumbIds[position]);
                textView.Text = thumbIds[position];
                return textView;
            }
        }
		public class MyAdapter : BaseAdapter
		{
			private readonly Context context;
			private readonly string[] thumbIds = {
				"Case Manager Assigned",
				"Telephone Number",
				"Email Address",
				"Sharon Douglas",
				"(518)473-6917",
				"SDOUGLAS@nysif.com"
			};
			int width, height;

			public MyAdapter(Context c, int _width, int _height)
			{
				context = c;
				width = _width;
				height = _height;

			}

			public override int Count
			{
				get { return thumbIds.Length; }
			}

			public override Java.Lang.Object GetItem(int position)
			{
				throw new NotImplementedException();
			}

			public override long GetItemId(int position)
			{
				return 0;
			}

			public override View GetView(int position, View convertView, ViewGroup parent)
			{
				TextView textView;

				if (convertView == null)
				{
					// if it's not recycled, initialize some attributes
					textView = new TextView(context);

					textView.LayoutParameters = new LinearLayout.LayoutParams(width / 3, height / 15);
					textView.Gravity = GravityFlags.Center;

					var shape = new ShapeDrawable(new RectShape());
					shape.Paint.Color = Color.White;
					shape.Paint.StrokeWidth = 1;
					shape.Paint.SetStyle(Paint.Style.Stroke);
					textView.SetPadding(0, 5, 0, 5);
					textView.SetBackgroundDrawable(shape);
				}
				else
				{
					textView = (TextView)convertView;
				}
				//textView.SetText(thumbIds[position]);
				textView.Text = thumbIds[position];
				return textView;
			}
		}
    }
}
