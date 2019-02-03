using Android.Content;
using Android.Graphics;
using Android.Views;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XFThemes.Droid.Renderers;

[assembly: ExportRenderer(typeof(ContentPage), typeof(DroidContentPageRenderer))]
namespace XFThemes.Droid.Renderers
{
    /// <summary>
    /// This renderer is created to handle the theming of the Android Toolbar
    /// On Constructor, it calls the method which does theme specific settings for Toolbar icons
    /// </summary>
    public class DroidContentPageRenderer : PageRenderer
    {
        public DroidContentPageRenderer(Context context) : base(context)
        {
            if (context == null) context = MainActivity.Instance;

            var toolbar = (context as MainActivity).FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (toolbar != null)
            {
                var color = (Xamarin.Forms.Color)Xamarin.Forms.Application.Current.Resources.MergedDictionaries.ToList()[0]["PrimaryTintColor"];
                PorterDuffColorFilter colorFilter = new PorterDuffColorFilter(color.ToAndroid(), PorterDuff.Mode.Multiply);

                //1. Changing Tint color for the Toolbar icons
                var menu = toolbar.Menu;
                if (menu != null && menu.HasVisibleItems)
                {
                    var i = 0;
                    while (true)
                    {
                        IMenuItem item = null;
                        try
                        {
                            item = menu.GetItem(i++);
                        }
                        catch (Java.Lang.IndexOutOfBoundsException)
                        {
                            break;
                        }
                        item.Icon?.SetColorFilter(colorFilter);
                    }
                }
            }
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