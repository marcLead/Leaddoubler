using System;
using leaddoubler.CustomControls;
using leaddoubler.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryWithRoundedBorder), typeof(EntryWithRoundedBorderRenderer))]
namespace leaddoubler.iOS
{
	public class EntryWithRoundedBorderRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BackgroundColor = UIColor.White;
				Control.BorderStyle = UITextBorderStyle.RoundedRect;
			}
		}
	}
}
