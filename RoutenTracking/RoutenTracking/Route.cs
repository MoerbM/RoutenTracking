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


namespace RoutenTracking
{
    class Route
    {
        string Titel;
        DateTime Datum;
        List<Koordinaten> KoordinatenListe;
        public Route()
        {
            this.Datum = DateTime.Now;
            KoordinatenListe = new List<Koordinaten>();
            
        }



        private async void GetLocationAsync()
        {

            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 100;

                Position position;
                position = await locator.GetLastKnownLocationAsync();

                if (position != null)
                {
                    //got a cahched position, so let's use it.

                }

                if (!locator.IsGeolocationAvailable || !locator.IsGeolocationEnabled)
                {
                    //not available or enabled

                }
                
                position = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);
                KoordinatenListe.Add(new Koordinaten(position.Latitude, position.Longitude));
            }
            catch (Exception ex)
            {


            }

        }

        async void StartListening()
        {
            if (CrossGeolocator.Current.IsListening)
                return;

            await CrossGeolocator.Current.StartListeningAsync(TimeSpan.FromSeconds(10), 10, true);

            CrossGeolocator.Current.PositionChanged += PositionChanged;
            CrossGeolocator.Current.PositionError += PositionError;
        }

        private void PositionChanged(object sender, PositionEventArgs e)
        {

            //If updating the UI, ensure you invoke on main thread
            var position = e.Position;
            KoordinatenListe.Add(new Koordinaten(position.Latitude, position.Longitude));

        }

        private void PositionError(object sender, PositionErrorEventArgs e)
        {
            
            //Handle event here for errors
        }

        async void StopListening()
        {
            if (!CrossGeolocator.Current.IsListening)
                return;

            await CrossGeolocator.Current.StopListeningAsync();

            CrossGeolocator.Current.PositionChanged -= PositionChanged;
            CrossGeolocator.Current.PositionError -= PositionError;
        }






        public void SpeicherKoordinaten()
        {



        }





    }
}