using System.Collections.Generic;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class SampleOrderDetailViewModel : Observable, IHierarchical
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(ref _isSelected, value); }
        }

        public string Name { get; }

        public SampleOrderDetail Model { get; }

        public IEnumerable<IHierarchical> Child { get; }

        public SampleOrderDetailViewModel(SampleOrderDetail model)
        {
            Model = model;
            Name = model.ShortDescription;
        }
    }
}
