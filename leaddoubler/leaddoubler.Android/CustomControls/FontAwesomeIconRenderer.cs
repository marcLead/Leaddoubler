﻿using System;
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
using leaddoubler.Droid.CustomControls;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using leaddoubler.CustomControls;

[assembly: ExportRenderer(typeof(FontAwesomeIcon), typeof(FontAwesomeIconRenderer))]
namespace leaddoubler.Droid.CustomControls
{
    class FontAwesomeIconRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                //The ttf in /Assets is CaseSensitive, so name it FontAwesome.ttf
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, FontAwesomeIcon.Typeface + ".ttf");
            }
        }
    }
}