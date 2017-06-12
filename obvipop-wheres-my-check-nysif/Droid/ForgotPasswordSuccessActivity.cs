
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
    [Activity(Label = "ForgotPasswordSuccessActivity")]
    public class ForgotPasswordSuccessActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

			// Create your application here
            SetContentView(Resource.Layout.forgot_password_success);

			Button forgotButton = (Button)FindViewById(Resource.Id.buttonFGoToLogin);
			forgotButton.Click += delegate
			{
                StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
			};
        }
    }
}
