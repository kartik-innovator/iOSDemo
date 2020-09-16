using Foundation;
using System;
using UIKit;

namespace iOSDemo
{
    public partial class HomeViewController : UIViewController
    {
        public HomeViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            imgServices.AddGestureRecognizer(new UITapGestureRecognizer(OnServicesTapped));
            lblServices.AddGestureRecognizer(new UITapGestureRecognizer(OnServicesTapped));

            imgWork.AddGestureRecognizer(new UITapGestureRecognizer(OnWorkTapped));
            lblWork.AddGestureRecognizer(new UITapGestureRecognizer(OnWorkTapped));

            imgGallery.AddGestureRecognizer(new UITapGestureRecognizer(OnGalleryTapped));
            lblGallery.AddGestureRecognizer(new UITapGestureRecognizer(OnGalleryTapped));

            imgContact.AddGestureRecognizer(new UITapGestureRecognizer(OnContactTapped));
            lblContact.AddGestureRecognizer(new UITapGestureRecognizer(OnContactTapped));
        }

        private void OnContactTapped()
        {
            PerformSegue("ToContact", null);
        }

        private void OnGalleryTapped()
        {
            PerformSegue("ToGallery", null);
        }

        private void OnWorkTapped()
        {
            PerformSegue("ToWork", null);
        }

        private void OnServicesTapped()
        {
            PerformSegue("ToServices", null);
        }
    }
}