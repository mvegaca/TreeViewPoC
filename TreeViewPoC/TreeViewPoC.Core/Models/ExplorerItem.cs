using System.Collections.Generic;

namespace TreeViewPoC.Core.Models
{
    public class ExplorerItem
    {
        public ExplorerItemType Type { get; set; }

        public string Name { get; set; }

        public IEnumerable<ExplorerItem> Children { get; set; }
    }
}
