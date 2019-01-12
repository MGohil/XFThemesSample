﻿using System.Collections.Generic;
using System.Linq;
using XFThemes.Models;

namespace XFThemes.ViewModels
{
    public class ThemeSelectionViewModel : BaseViewModel
    {
        public ThemeSelectionViewModel()
        {
            Title = "Select Theme";

            Themes = new List<AppTheme>()
            {
                new AppTheme() { ThemeId = ThemeManager.Themes.Light, Title = "Light Theme", Description = "Gives a light theme experience" },
                new AppTheme() { ThemeId = ThemeManager.Themes.Dark, Title = "Dark Theme", Description = "Gives a dark theme experience" },
                new AppTheme() { ThemeId = ThemeManager.Themes.Blue, Title = "Blue Theme", Description = "Gives a blue theme experience" },
                new AppTheme() { ThemeId = ThemeManager.Themes.Orange, Title = "Orange Theme", Description = "Gives an orange theme experience" },
                new AppTheme() { ThemeId = ThemeManager.Themes.White, Title = "White Theme", Description = "Gives a white theme experience" }
            };

            var selectedTheme = Themes.FirstOrDefault(x => x.ThemeId == ThemeManager.CurrentTheme());
            selectedTheme.IsSelected = true;
        }

        List<AppTheme> _themes;
        public List<AppTheme> Themes
        {
            get { return _themes; }
            set { SetProperty(ref _themes, value); }
        }

        AppTheme _selectedTheme;
        public AppTheme SelectedTheme
        {
            get { return _selectedTheme; }
            set
            {
                SetProperty(ref _selectedTheme, value);
                if (value != null) { OnThemeSelected(value); }
            }
        }

        private void OnThemeSelected(AppTheme selectedTheme)
        {
            foreach (var t in Themes)
            {
                t.IsSelected = t.ThemeId == selectedTheme.ThemeId;
            }
            ThemeManager.ChangeTheme(selectedTheme.ThemeId);
        }
    }
}