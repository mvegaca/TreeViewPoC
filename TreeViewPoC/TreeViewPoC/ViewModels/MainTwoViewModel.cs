using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Core.Services;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class MainTwoViewModel : Observable
    {
        public ObservableCollection<SampleCompany> DataSource { get; } = new ObservableCollection<SampleCompany>();

        public MainTwoViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            var data = await SampleDataService.GetSampleModelCpmpaniesDataAsync();
            foreach (var item in data)
            {
                DataSource.Add(item);
            }
        }
    }
}
