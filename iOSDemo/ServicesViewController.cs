using Foundation;
using System;
using UIKit;

namespace iOSDemo
{
    public partial class ServicesViewController : UIViewController
    {
        public ServicesViewController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.SetNavigationBarHidden(false, true);
        }
    }
}