using Xamarin.Forms;
using XFThemes.Dependencies;
using XFThemes.Droid.Dependencies;

[assembly: Dependency(typeof(NativeServices))]
namespace XFThemes.Droid.Dependencies
{
    public class NativeServices : INativeServices
    {
        public void OnThemeChanged(ThemeManager.Themes theme)
        {
            MainActivity.Instance.Recreate();
        }
    }
}
