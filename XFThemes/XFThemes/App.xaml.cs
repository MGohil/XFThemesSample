using Xamarin.Forms;

namespace XFThemes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            ThemeManager.LoadTheme();
            MainPage = new NavigationPage(new XFThemes.DashboardPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
