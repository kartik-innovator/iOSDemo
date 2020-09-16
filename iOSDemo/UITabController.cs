using Foundation;
using System;
using UIKit;

namespace iOSDemo
{
    public partial class UITabController : UITabBarController
    {
        public UITabController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            NavigationController.SetNavigationBarHidden(true, true);
        }
    }
}