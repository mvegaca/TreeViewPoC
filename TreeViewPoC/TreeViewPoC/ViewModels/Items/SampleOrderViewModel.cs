using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class SampleOrderViewModel : Observable, IHierarchical
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(ref _isSelected, value); }
        }

        public string Name { get; }

        public SampleOrder Model { get; }

        public IEnumerable<IHierarchical> Child { get; }

        public SampleOrderViewModel(SampleOrder model)
        {
            Model = model;
            Name = model.ShortDescription;
            Child = new ObservableCollection<SampleOrderDetailViewModel>(model.Details.Select(od => new SampleOrderDetailViewModel(od)));
        }
    }
}
