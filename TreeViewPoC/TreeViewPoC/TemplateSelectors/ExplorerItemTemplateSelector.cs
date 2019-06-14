using TreeViewPoC.Core.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TreeViewPoC.TemplateSelectors
{
    public class ExplorerItemTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FolderTemplate { get; set; }

        public DataTemplate FileTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item)
        {
            if (item is ExplorerItem explorerItem)
            {
                switch (explorerItem.Type)
                {
                    case ExplorerItemType.Folder:
                        return FolderTemplate;
                    case ExplorerItemType.File:
                        return FileTemplate;
                }
            }

            return base.SelectTemplateCore(item);
        }
    }
}
