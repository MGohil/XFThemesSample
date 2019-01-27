using Android.Content;
using Android.Graphics;
using Android.Views;
using System.Linq;
using Xamarin.Forms.Platform.Android;

namespace XFThemes.Droid.Helpers
{
    public static class ToolbarHelper
    {
        /// <summary>
        /// Sets the color of the Toolbar custom icons
        /// This uses the "PrimaryTintColor" as an icon color
        /// </summary>
        /// <param name="context"></param>
        public static void ThemifyToolbar(Context context)
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
    }
}