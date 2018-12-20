using System;
using leaddoubler.CustomControls;
using leaddoubler.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EditorWithRoundedBorder), typeof(EditorWithRoundedBorderRenderer))]
namespace leaddoubler.iOS
{
	public class EditorWithRoundedBorderRenderer:EditorRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				Control.BackgroundColor = UIColor.White;
			}
		}
	}
}
