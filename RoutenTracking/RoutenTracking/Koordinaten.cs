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
    class Koordinaten
    {
        DateTimeOffset Erstelldatum;
        double Längengrad;
        double Breitengrad;
        

        public Koordinaten(double _Breitengrad, double _Längengrad)
        {
            
            Längengrad = _Längengrad;
            Breitengrad = _Breitengrad;
            Erstelldatum = DateTimeOffset.UtcNow;
        }

    }
}