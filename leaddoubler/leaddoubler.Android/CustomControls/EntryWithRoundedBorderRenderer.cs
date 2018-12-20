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

[assembly: ExportRenderer(typeof(EntryWithRoundedBorder), typeof(EntryWithRoundedBorderRenderer))]
namespace leaddoubler.Droid.CustomControls
{
    public class EntryWithRoundedBorderRenderer:EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = null;
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.White);
                float[] a = new float[] { 0, 0, 8, 8, 8, 8, 0, 0 };
                gd.SetCornerRadii(a);
                gd.SetStroke(2, Android.Graphics.Color.Rgb(216,224,228));
                Control.SetBackgroundDrawable(gd);
                Control.SetPaddingRelative(7, 11, 7, 7);
            }
        }
    }
}