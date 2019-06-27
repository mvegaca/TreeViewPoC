using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class SampleCompanyViewModel : Observable, IHierarchical
    {
        private bool _isSelected;

        public bool IsSelected
        {
            get { return _isSelected; }
            set { Set(ref _isSelected, value); }
        }

        public string Name { get; }

        public SampleCompany Model { get; }

        public IEnumerable<IHierarchical> Child { get;  }
       
        public SampleCompanyViewModel(SampleCompany model)
        {
            Model = model;
            Name = model.CompanyName;
            Child = new ObservableCollection<SampleOrderViewModel>(model.Orders.Select(o => new SampleOrderViewModel(o)));
        }
    }
}
