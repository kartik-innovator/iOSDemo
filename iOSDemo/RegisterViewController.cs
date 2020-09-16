using CoreGraphics;
using Foundation;
using System;
using UIKit;

namespace iOSDemo
{
    public partial class RegisterViewController : UIViewController
    {
        public RegisterViewController (IntPtr handle) : base (handle)
        {
        }

        public RegisterViewController()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var t = NavigationController;
            t.SetNavigationBarHidden(false, true);
            CreateDatePicker();
            //NavigationController.PopToRootViewController(true);
        }

        bool maleSelected = false;
        partial void UIButton4707_TouchUpInside(UIButton sender)
        {
            maleSelected = !maleSelected;
            if(maleSelected)
            {
                sender.SetBackgroundImage(new UIImage("radio_select.png"), UIControlState.Normal);
                if(femaleSelected)
                {
                    femaleSelected = false;
                    btnFemale.SetBackgroundImage(new UIImage("radio.png"), UIControlState.Normal);
                }
            }
            else
            {
                sender.SetBackgroundImage(new UIImage("radio.png"), UIControlState.Normal);
            }
        }

        bool femaleSelected = false;
        partial void UIButton5029_TouchUpInside(UIButton sender)
        {
            femaleSelected = !femaleSelected;
            if (femaleSelected)
            {
                sender.SetBackgroundImage(new UIImage("radio_select.png"), UIControlState.Normal);
                if(maleSelected)
                {
                    maleSelected = false;
                    btnMale.SetBackgroundImage(new UIImage("radio.png"), UIControlState.Normal);
                }
            }
            else
            {
                sender.SetBackgroundImage(new UIImage("radio.png"), UIControlState.Normal);
            }
        }

        

        private void CreateDatePicker()
        {
            UIDatePicker datePicker = new UIDatePicker();
            datePicker.Mode = UIDatePickerMode.Date;
            datePicker.BackgroundColor = UIColor.White;

            //datePicker.MinimumDate = (NSDate)DateTime.Today.AddDays(-7);
            datePicker.MaximumDate = (NSDate)DateTime.Today;

            UIToolbar toolbar = new UIToolbar();
            toolbar.BarStyle = UIBarStyle.Default;
            toolbar.Translucent = true;
            toolbar.SizeToFit();

            UIBarButtonItem doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
                (s, e) => {
                    DateTime dateTime = DateTime.SpecifyKind((DateTime)datePicker.Date, DateTimeKind.Unspecified);
                    this.UITextFieldDOB.Text = dateTime.ToString("MM-dd-yyyy");
                    this.UITextFieldDOB.ResignFirstResponder();
                });

            toolbar.SetItems(new UIBarButtonItem[] { doneButton }, true);

            UITextFieldDOB.InputAccessoryView = toolbar;

            UITextFieldDOB.InputView = datePicker;
        }
    }
}