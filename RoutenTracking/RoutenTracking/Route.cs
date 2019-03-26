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
            GetLocationAsync.
        }

        


        private async Task<Position> GetLocationAsync()
        {
            Position position = null;
            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 100;

                position = await locator.GetLastKnownLocationAsync();

                if (position != null)
                {
                    //got a cahched position, so let's use it.
                    return position;
                }

                if (!locator.IsGeolocationAvailable || !locator.IsGeolocationEnabled)
                {
                    //not available or enabled
                    return null;
                }

                position = await locator.GetPositionAsync(TimeSpan.FromSeconds(20), null, true);

            }
            catch (Exception ex)
            {


            }

            if (position == null)
                return null;

            return position;
        }
        
          
        



        public void SpeicherKoordinaten()
        {



        }




        

}