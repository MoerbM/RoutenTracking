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
            StopButton.Click += (sender, e) =>
            {
                var intent = new Intent(this, typeof(MainActivity));

                StartActivity(intent);
                Finish();
            };
        }
    }
}