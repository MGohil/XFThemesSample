using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFThemes.Droid.Helpers;
using XFThemes.Droid.Renderers;

[assembly: ExportRenderer(typeof(ContentPage), typeof(NavigationPageRendererDroid))]
namespace XFThemes.Droid.Renderers
{
    /// <summary>
    /// This renderer is created to handle the theming of the Android Toolbar
    /// On Constructor, it calls the method which does theme specific settings for Toolbar icons
    /// </summary>
    public class NavigationPageRendererDroid : PageRenderer
    {
        public NavigationPageRendererDroid(Context c) : base(c)
        {
            ToolbarHelper.ThemifyToolbar(c);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                if (Element == null)
                    return;
            }
        }
    }
}