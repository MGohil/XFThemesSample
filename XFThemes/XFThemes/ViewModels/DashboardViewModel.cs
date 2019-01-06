using System;
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

        public Command ThemeSelectionPageCommand { get; set; }
        private void ThemeSelectionPageCommandExecute(object obj)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ThemeSelectionPage());
        }

        public Command GoToProfilePageCommand { get; set; }
        private void GoToProfilePageCommandExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new MyProfilePage());
        }
    }
}
