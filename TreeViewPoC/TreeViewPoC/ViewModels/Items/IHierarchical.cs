using System.Collections.Generic;

namespace TreeViewPoC.ViewModels
{
    public interface IHierarchical
    {
        string Name { get; }

        bool IsSelected { get; set; }

        IEnumerable<IHierarchical> Child { get; }
    }
}
