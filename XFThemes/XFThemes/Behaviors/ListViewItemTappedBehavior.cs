using System.Windows.Input;
using Xamarin.Forms;

namespace XFThemes
{
    public class ListViewItemTappedBehavior : Behavior<ListView>
    {
        public Command Command { get; set; }

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemTapped += OnListViewItemTapped;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.ItemTapped -= OnListViewItemTapped;
        }

        private void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (Command == null || e.Item == null) return;
            if (Command.CanExecute(e.Item)) Command.Execute(e.Item);
        }
    }
}
