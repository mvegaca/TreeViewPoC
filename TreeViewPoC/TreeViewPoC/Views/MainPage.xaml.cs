using System;

using TreeViewPoC.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TreeViewPoC.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
