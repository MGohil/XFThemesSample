using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XFThemes.iOS.Renderers;

[assembly: ExportRenderer(typeof(ViewCell), typeof(ListViewCellICustomRenderer))]
namespace XFThemes.iOS.Renderers
{
    public class ListViewCellICustomRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            //For iOS, when we select any ListView item, we dont' want to display any selection color for that item.
            //So, following line sets the selectionstyle to None
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}