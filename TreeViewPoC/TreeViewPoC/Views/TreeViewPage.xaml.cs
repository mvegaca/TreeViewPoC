using System;
using TreeViewPoC.Helpers;
using TreeViewPoC.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TreeViewPoC.Views
{
    public sealed partial class TreeViewPage : Page
    {
        public TreeViewViewModel ViewModel { get; } = new TreeViewViewModel();

        public TreeViewPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadDataAsync();
        }        
    }
}
