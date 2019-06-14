using System;

using TreeViewPoC.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace TreeViewPoC.Views
{
    public sealed partial class MainTwoPage : Page
    {
        public MainTwoViewModel ViewModel { get; } = new MainTwoViewModel();

        public MainTwoPage()
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
