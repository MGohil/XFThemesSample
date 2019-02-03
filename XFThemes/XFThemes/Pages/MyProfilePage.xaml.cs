using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFThemes
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyProfilePage : ContentPage
	{
		public MyProfilePage ()
		{
			InitializeComponent ();

            //Primary Toolbar buttons
            //1. Edit (as Icon)
            var editProfileToolbarItem = new ToolbarItem { Text = "EDIT", Icon = "editprofile" };
            //2. SAVE (as Text)
            var saveProfileToolbarItem = new ToolbarItem { Text = "SAVE" };
            ToolbarItems.Add(editProfileToolbarItem);
            ToolbarItems.Add(saveProfileToolbarItem);

            //Android Only : Secondary Toolbar Items
            if (Device.RuntimePlatform == Device.Android)
            {
                var toolbarItem1 = new ToolbarItem { Text = "Item 1", Priority = 1, Order = ToolbarItemOrder.Secondary };
                var toolbarItem2 = new ToolbarItem { Text = "Item 2", Priority = 1, Order = ToolbarItemOrder.Secondary };
                var toolbarItem3 = new ToolbarItem { Text = "Item 3", Priority = 1, Order = ToolbarItemOrder.Secondary };
                ToolbarItems.Add(toolbarItem1);
                ToolbarItems.Add(toolbarItem2);
                ToolbarItems.Add(toolbarItem3);
            }
        }
    }
}