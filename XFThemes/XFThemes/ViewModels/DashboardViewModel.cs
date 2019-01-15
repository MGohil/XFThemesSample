using Xamarin.Forms;

namespace XFThemes.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public DashboardViewModel()
        {
            Title = "Dashboard";
            ThemeSelectionPageCommand = new Command(ThemeSelectionPageCommandExecute);
            GoToProfilePageCommand = new Command(GoToProfilePageCommandExecute);
        }

        /// <summary>
        /// Command to invoke when you want to navigate to the ThemeSelection page
        /// </summary>
        public Command ThemeSelectionPageCommand { get; set; }
        private void ThemeSelectionPageCommandExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ThemeSelectionPage());
        }

        /// <summary>
        /// Command to invoke when you want to navigate to Profile page
        /// </summary>
        public Command GoToProfilePageCommand { get; set; }
        private void GoToProfilePageCommandExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new MyProfilePage());
        }
    }
}
