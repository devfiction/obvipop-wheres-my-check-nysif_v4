
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

namespace wheres.my.check.nysif.Droid
{
    [Activity(Label = "RegistrationSuccessActivity")]
    public class RegistrationSuccessActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.new_user_success);

            Button gotologinButton = (Button)FindViewById(Resource.Id.button2);
			gotologinButton.Click += delegate
			{
                StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
			};
        }
    }
}
