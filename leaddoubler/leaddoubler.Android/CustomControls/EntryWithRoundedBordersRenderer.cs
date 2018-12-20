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
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using leaddoubler.CustomControls;
using leaddoubler.Droid.CustomControls;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(EntryWithRoundedBorders), typeof(EntryWithRoundedBordersRenderer))]
namespace leaddoubler.Droid.CustomControls
{
    class EntryWithRoundedBordersRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                float[] a = new float[] { 8, 8, 8, 8, 8, 8, 8, 8 };
                gd.SetCornerRadii(a);
                gd.SetStroke(2, Android.Graphics.Color.Rgb(216, 224, 228));
                Control.SetBackgroundDrawable(gd);
                Control.SetPaddingRelative(12,12,12,12);
            }
        }
    }
}