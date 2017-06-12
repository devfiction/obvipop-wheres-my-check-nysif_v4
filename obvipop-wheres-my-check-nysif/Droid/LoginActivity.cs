
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
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Main);


            Button loginButton = (Button)FindViewById(Resource.Id.button);
            loginButton.Click += delegate
            {
                StartActivity(new Intent(Application.Context, typeof(DataEntryActivity)));
            };

            TextView txtForgotPassword = (TextView)FindViewById(Resource.Id.textView7);
			txtForgotPassword.Click += delegate
			{
                StartActivity(new Intent(Application.Context, typeof(ForgotPasswordActivity)));
			};

			TextView txtSignUP = (TextView)FindViewById(Resource.Id.textView8);
			txtSignUP.Click += delegate
			{
                StartActivity(new Intent(Application.Context, typeof(NewUserActivity)));
			};
        }

    }
}
