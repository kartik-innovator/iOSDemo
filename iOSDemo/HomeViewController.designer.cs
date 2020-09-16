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
    [Register ("HomeViewController")]
    partial class HomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgContact { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgGallery { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgServices { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgWork { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblContact { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblGallery { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblServices { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblWork { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgContact != null) {
                imgContact.Dispose ();
                imgContact = null;
            }

            if (imgGallery != null) {
                imgGallery.Dispose ();
                imgGallery = null;
            }

            if (imgServices != null) {
                imgServices.Dispose ();
                imgServices = null;
            }

            if (imgWork != null) {
                imgWork.Dispose ();
                imgWork = null;
            }

            if (lblContact != null) {
                lblContact.Dispose ();
                lblContact = null;
            }

            if (lblGallery != null) {
                lblGallery.Dispose ();
                lblGallery = null;
            }

            if (lblServices != null) {
                lblServices.Dispose ();
                lblServices = null;
            }

            if (lblWork != null) {
                lblWork.Dispose ();
                lblWork = null;
            }
        }
    }
}