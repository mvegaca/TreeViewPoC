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
    public sealed partial class TreeViewThreePage : Page
    {
        public TreeViewThreeViewModel ViewModel { get; } = new TreeViewThreeViewModel();

        public TreeViewThreePage()
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
