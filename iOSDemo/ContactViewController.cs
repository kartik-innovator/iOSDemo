using Foundation;
using System;
using UIKit;

namespace iOSDemo
{
    public partial class ContactViewController : UIViewController
    {
        public ContactViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.SetNavigationBarHidden(false, true);
        }
    }
}