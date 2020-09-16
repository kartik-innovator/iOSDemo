using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace iOSDemo
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            var tap = new UITapGestureRecognizer(OnSignUPTapped);
            lblSignUp.AddGestureRecognizer(tap);
            
        }

        private void OnSignUPTapped()
        {
            PerformSegue("ToRegister", this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }


        partial void UIButton695_TouchUpInside(UIButton sender)
        {
            //Login
            //var arr = new UIViewController[10];
            //arr[0].View

            //NavigationController.SetViewControllers(new UIViewController("ToRegister", null), true);

            //NavigationController.PopToRootViewController(true);
            //NavigationController.PushViewController(new RegisterViewController(), true);
            //PerformSegue("ToRegister", this);
            var tt = UIStoryboard.FromName("Main", null).InstantiateViewController("TabBar");
            UIApplication.SharedApplication.KeyWindow.RootViewController = new UINavigationController(tt);
        }

        partial void UIButton475_TouchUpInside(UIButton sender)
        {
            //Forgot Password
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            var t = NavigationController;
            t.SetNavigationBarHidden(true, true);
        }
    }
}