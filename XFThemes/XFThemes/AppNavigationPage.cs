using Xamarin.Forms;

namespace XFThemes
{
    public class AppNavigationPage : NavigationPage
    {
        public AppNavigationPage(ContentPage page) : base(page)
        {
            SetDynamicResource(BarBackgroundColorProperty, "AccentColor");
            SetDynamicResource(BarTextColorProperty, "PrimaryTextColor");
        }
    }
}
