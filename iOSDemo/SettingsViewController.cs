using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace iOSDemo
{
    public partial class SettingsViewController : UIViewController
    {
        public SettingsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var list = new List<Settings>()
            {
                new Settings() {Icon = "bell.png", Title = "Notifications & Alerts" },
                new Settings() {Icon = "person.png", Title = "Profile" },
                new Settings() {Icon = "password.png", Title = "Change Password" },
                new Settings() {Icon = "shutdown.png", Title = "Logout" }
                
            };

            tableSettings.Source = new TableSource(list, this);
            tableSettings.TableFooterView = new UILabel();
        }
    }
}