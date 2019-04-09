using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.Geolocator;
using Android.App;
using Android.Content;
using Android.Locations;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Threading.Tasks;
using Plugin.Geolocator.Abstractions;
using System.Threading;

namespace RoutenTracking
{
    [Activity(Label = "Tracking")]
    public class TrackingActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_tracking);

            // Create your application here
            Button StopButton = (Button)FindViewById(Resource.Id.StopButton);
            TextView textLongitude = (TextView)FindViewById(Resource.Id.textLongitude);
            TextView textLatitude = (TextView)FindViewById(Resource.Id.textLatitude);
            StopButton.Click += StopBtn_Click;

            Route Strecke = new Route();
            Strecke.
           

        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));

        }
    }
}