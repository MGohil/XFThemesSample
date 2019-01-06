using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFThemes.Models;

namespace XFThemes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThemeSelectionPage : ContentPage
    {
        public ThemeSelectionPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ThemeManager.ChangeTheme((e.Item as AppTheme).ThemeId);
            (sender as ListView).SelectedItem = null;
            //Application.Current.MainPage = new NavigationPage(new DashboardPage());
        }
    }
}