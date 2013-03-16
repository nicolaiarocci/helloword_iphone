using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace helloword_ihpone
{
	public partial class helloword_ihponeViewController : UIViewController
	{
		protected int _numberOfTimesClicked = 0;

		public helloword_ihponeViewController () : base ("helloword_ihponeViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			//--- wire up out click me button
			this.btnClickMe.TouchUpInside += (sender, e) => {
				this._numberOfTimesClicked++;
				this.lblOutput.Text = "Clicked [" + this._numberOfTimesClicked.ToString() + "] times";
			};
		}

		partial void actnButtonClick (NSObject sender)
		{
			this.lblOutput.Text = "Action button " + ((UIButton)sender).CurrentTitle + " clicked.";
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

