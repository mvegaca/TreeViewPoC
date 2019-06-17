using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Core.Services;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class TreeViewViewModel : Observable
    {
        private object _selectedItem;

        public object SelectedItem
        {
            get { return _selectedItem; }
            set { Set(ref _selectedItem, value); }
        }

        public ObservableCollection<SampleCompany> DataSource { get; } = new ObservableCollection<SampleCompany>();

        public TreeViewViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            var data = await SampleDataService.GetCompaniesDataAsync();
            foreach (var item in data)
            {
                DataSource.Add(item);
            }

            if (DataSource.Any())
            {
                SelectedItem = DataSource.First();
            }
        }
    }
}
