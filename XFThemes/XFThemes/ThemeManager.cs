using Plugin.Settings;
using Xamarin.Forms;
using XFThemes.ThemeResources;

namespace XFThemes
{
    public class ThemeManager
    {
        public enum Themes
        {
            Light,
            Dark,
            Blue,
            Orange
        }

      
        public static void ChangeTheme(Themes theme)
        {
            var mergedDictionaries = Application.Current.Resources.MergedDictionaries;
            if (mergedDictionaries != null)
            {
                mergedDictionaries.Clear();
                CrossSettings.Current.AddOrUpdateValue("SelectedTheme", (int)theme);
                switch (theme)
                {
                    case Themes.Light:
                        {
                            mergedDictionaries.Add(new LightTheme());
                            break;
                        }
                    case Themes.Dark:
                        {
                            mergedDictionaries.Add(new DarkTheme());
                            break;
                        }
                    case Themes.Blue:
                        {
                            mergedDictionaries.Add(new BlueTheme());
                            break;
                        }
                    case Themes.Orange:
                        {
                            mergedDictionaries.Add(new OrangeTheme());
                            break;
                        }
                    default:
                        mergedDictionaries.Add(new LightTheme());
                        break;
                }
            }
        }

        public static void LoadTheme()
        {
            Themes currentTheme = CurrentTheme();
            ChangeTheme(currentTheme);
        }

        public static Themes CurrentTheme()
        {
            return (Themes)CrossSettings.Current.GetValueOrDefault("SelectedTheme", (int)Themes.Light);
        }
    }
}
