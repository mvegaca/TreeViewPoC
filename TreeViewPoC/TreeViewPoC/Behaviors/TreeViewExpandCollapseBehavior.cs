using System.Windows.Input;
using Microsoft.Xaml.Interactivity;
using TreeViewPoC.Helpers;
using WinUI = Microsoft.UI.Xaml.Controls;

namespace TreeViewPoC.Behaviors
{
    public class TreeViewExpandCollapseBehavior : Behavior<WinUI.TreeView>
    {
        public ICommand ExpandAllCommand { get; }

        public ICommand CollapseAllCommand { get; }

        public TreeViewExpandCollapseBehavior()
        {
            CollapseAllCommand = new RelayCommand(OnCollapseAll);
            ExpandAllCommand = new RelayCommand(OnExpandAll);
        }

        private void OnCollapseAll()
        {
            foreach (var node in AssociatedObject.RootNodes)
            {
                CollapseNode(node);
            }
        }

        private void OnExpandAll()
        {
            foreach (var node in AssociatedObject.RootNodes)
            {
                ExpandNode(node);
            }
        }        

        private void CollapseNode(WinUI.TreeViewNode node)
        {
            if (node.HasChildren)
            {
                foreach (var child in node.Children)
                {
                    CollapseNode(child);
                }
            }

            AssociatedObject.Collapse(node);
        }

        private void ExpandNode(WinUI.TreeViewNode node)
        {
            if (node.HasChildren)
            {
                foreach (var child in node.Children)
                {
                    ExpandNode(child);
                }
            }

            AssociatedObject.Expand(node);
        }        
    }
}
