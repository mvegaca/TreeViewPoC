using System;
using TreeViewPoC.Helpers;
using TreeViewPoC.ViewModels;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TreeViewPoC.Views
{
    // For more info about the TreeView Control see
    // https://docs.microsoft.com/en-us/windows/uwp/design/controls-and-patterns/tree-view
    // For other samples, get the XAML Controls Gallery app http://aka.ms/XamlControlsGallery
    public sealed partial class TreeViewFourPage : Page
    {
        public TreeViewFourViewModel ViewModel { get; } = new TreeViewFourViewModel();

        public TreeViewFourPage()
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
