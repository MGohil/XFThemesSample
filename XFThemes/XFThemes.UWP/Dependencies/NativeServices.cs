using Xamarin.Forms;
using XFThemes.Dependencies;
using XFThemes.UWP.Dependencies;

[assembly: Dependency(typeof(NativeServices))]
namespace XFThemes.UWP.Dependencies
{
    class NativeServices : INativeServices
    {
        public void OnThemeChanged(ThemeManager.Themes theme)
        {
            App.ApplyThemedColors();
        }
    }
}
