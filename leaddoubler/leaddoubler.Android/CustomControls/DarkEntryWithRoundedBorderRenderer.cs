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
using Xamarin.Forms;
using leaddoubler.CustomControls;
using leaddoubler.Droid.CustomControls;
using Xamarin.Forms.Platform.Android;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(DarkEntryWithRoundedBorder), typeof(DarkEntryWithRoundedBorderRenderer))]
namespace leaddoubler.Droid.CustomControls
{
    class DarkEntryWithRoundedBorderRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.Rgb(238, 238, 238));
                float[] a = new float[] { 8, 8, 0, 0,0, 0, 8, 8 };
                gd.SetCornerRadii(a);
                gd.SetStroke(2, Android.Graphics.Color.Rgb(204, 204, 204));
                Control.SetBackgroundDrawable(gd);
                Control.SetPaddingRelative(7, 7, 7, 7);
            }
        }
    }
}