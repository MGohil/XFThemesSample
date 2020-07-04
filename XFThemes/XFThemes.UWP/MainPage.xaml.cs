using Xamarin.Forms.Platform.UWP;

namespace XFThemes.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new XFThemes.App());

            App.ApplyThemedColors();
        }
    }
}
