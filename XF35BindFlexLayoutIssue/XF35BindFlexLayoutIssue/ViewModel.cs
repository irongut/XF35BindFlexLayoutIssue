using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XF35BindFlexLayoutIssue
{
    public class ViewModel
    {
        private const string ipsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public ObservableCollection<ListItem> ItemsList { get; set; }

        public ViewModel()
        {
            ItemsList = new ObservableCollection<ListItem>();
        }

        private void RefreshView()
        {
            ItemsList.Clear();
            for (int i = 0; i < 11; i++)
            {
                ItemsList.Add(new ListItem(
                                    String.Format("Item Title #{0}", i),
                                    String.Format("Item Text #{0} {1}", i, ipsum)));
            }
        }

        public void OnAppearing()
        {
            RefreshView();
            MessagingCenter.Subscribe<App>(this, "AppOnResume", (_) => RefreshView());
        }

        public virtual void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<App>(this, "AppOnResume");
        }
    }
}
