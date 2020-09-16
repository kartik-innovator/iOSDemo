using System;
using UIKit;

namespace iOSDemo
{
    public partial class SettingCell : UITableViewCell
    {
        public SettingCell (IntPtr handle) : base (handle)
        {
        }
        internal void UpdateCell(Settings settings)
        {
            imgIcon.Image = UIImage.FromFile(settings.Icon);
            lblTitle.Text = settings.Title;
        }
    }
}