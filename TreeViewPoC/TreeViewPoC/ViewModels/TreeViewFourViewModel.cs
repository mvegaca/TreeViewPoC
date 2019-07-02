using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Core.Services;
using TreeViewPoC.Helpers;
using WinUI = Microsoft.UI.Xaml.Controls;

namespace TreeViewPoC.ViewModels
{
    public class TreeViewFourViewModel : Observable
    {
        private ICommand _itemInvokedCommand;
        private object _selectedItem;

        public object SelectedItem
        {
            get { return _selectedItem; }
            set { Set(ref _selectedItem, value); }
        }

        public ObservableCollection<SampleData> SampleItems { get; } = new ObservableCollection<SampleData>();

        public ICommand ItemInvokedCommand => _itemInvokedCommand ?? (_itemInvokedCommand = new RelayCommand<WinUI.TreeViewItemInvokedEventArgs>(OnItemInvoked));

        public TreeViewFourViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            var data = await SampleDataService.GetCompaniesDataAsync();
            SampleItems.Add(new SampleData() { Companies = data });
        }

        private void OnItemInvoked(WinUI.TreeViewItemInvokedEventArgs args)
            => SelectedItem = args.InvokedItem;
    }
}



