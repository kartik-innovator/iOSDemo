using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace iOSDemo
{
    public class TableSource : UITableViewSource, IUIAlertViewDelegate
    {
        List<Settings> list;
        public TableSource() { }
        SettingsViewController Owner;
        public TableSource(List<Settings> list, SettingsViewController owner)
        {
            this.list = list;
            Owner = owner;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (SettingCell)tableView.DequeueReusableCell("Cell_Id", indexPath);
            Settings item = list[indexPath.Row];
            cell.UpdateCell(item);
            return cell;
        }
        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return list.Count;
        }
        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, false);
            Settings item = list[indexPath.Row];
            UIAlertController okAlertController = UIAlertController.Create("Row Selected", item.Title, UIAlertControllerStyle.Alert);
            okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
            Owner.PresentViewController(okAlertController, true, null);
            

        }
    }
}
