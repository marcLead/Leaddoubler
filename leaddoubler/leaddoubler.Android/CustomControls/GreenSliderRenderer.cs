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
using Android.Graphics;

[assembly: ExportRenderer(typeof(GreenSlider), typeof(GreenSliderRenderer))]
namespace leaddoubler.Droid.CustomControls
{
    class GreenSliderRenderer:SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ProgressDrawable.SetColorFilter(Android.Graphics.Color.Rgb(104,161,121), PorterDuff.Mode.SrcIn);
                Control.Thumb.SetColorFilter(Android.Graphics.Color.Rgb(104, 161, 121), PorterDuff.Mode.SrcIn);
            }
        }
    }
}