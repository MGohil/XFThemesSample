using XFThemes.ViewModels;

namespace XFThemes.Models
{
    public class AppTheme : ObservableObject
    {
        public ThemeManager.Themes ThemeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        bool _isSelected = false;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { SetProperty(ref _isSelected, value); }
        }
    }
}
