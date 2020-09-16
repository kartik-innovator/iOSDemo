// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iOSDemo
{
    [Register ("RegisterViewController")]
    partial class RegisterViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnFemale { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnMale { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField UITextFieldDOB { get; set; }

        [Action ("UIButton4707_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton4707_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton5029_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton5029_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnFemale != null) {
                btnFemale.Dispose ();
                btnFemale = null;
            }

            if (btnMale != null) {
                btnMale.Dispose ();
                btnMale = null;
            }

            if (UITextFieldDOB != null) {
                UITextFieldDOB.Dispose ();
                UITextFieldDOB = null;
            }
        }
    }
}