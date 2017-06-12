using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Threading;
using System.Threading.Tasks;
using Android.Content;

namespace wheres.my.check.nysif.Droid
{
    [Activity(Label = "wheres.my.check.nysif", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
	{

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
            SetContentView(Resource.Layout.splash);


		}

		protected override void OnResume()
		{
			base.OnResume();
			Task startupWork = new Task(() => { SimulateStartup(); });
			startupWork.Start();
		}
		// Simulates background work that happens behind the splash screen
		async void SimulateStartup()
		{
			await Task.Delay(2000); // Simulate a bit of startup work.
            StartActivity(new Intent(Application.Context, typeof(LoginActivity)));
		}

    }

}

