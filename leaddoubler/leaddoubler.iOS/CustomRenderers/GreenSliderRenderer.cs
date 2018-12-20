using System;
using leaddoubler.CustomControls;
using leaddoubler.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GreenSlider), typeof(GreenSliderRenderer))]
namespace leaddoubler.iOS
{
	public class GreenSliderRenderer : SliderRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.ThumbTintColor = UIColor.FromRGB(104, 161, 121);
				Control.TintColor = UIColor.FromRGB(104, 161, 121);
			}
		}
	}
}
