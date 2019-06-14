using System;

using TreeViewPoC.Core.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewPoC.Views
{
    public sealed partial class MainThreeDetailControl : UserControl
    {
        public object TreeViewSelectedItem
        {
            get { return GetValue(TreeViewSelectedItemProperty); }
            set { SetValue(TreeViewSelectedItemProperty, value); }
        }

        public static readonly DependencyProperty TreeViewSelectedItemProperty = DependencyProperty.Register("TreeViewSelectedItem", typeof(object), typeof(MainThreeDetailControl), new PropertyMetadata(null, OnTreeViewSelectedItemPropertyChanged));

        public MainThreeDetailControl()
        {
            InitializeComponent();
        }

        private static void OnTreeViewSelectedItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as MainThreeDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
