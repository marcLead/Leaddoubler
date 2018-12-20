using System;
using leaddoubler.CustomControls;
using leaddoubler.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(DarkEntryWithRoundedBorder), typeof(DarkEntryWithRoundedBorderRenderer))]
namespace leaddoubler.iOS
{
	public class DarkEntryWithRoundedBorderRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BackgroundColor = UIColor.FromRGB(238,238,238);
				Control.BorderStyle = UITextBorderStyle.RoundedRect;
			}
		}
	}
}
