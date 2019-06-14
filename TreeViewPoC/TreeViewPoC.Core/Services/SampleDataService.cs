using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using TreeViewPoC.Core.Helpers;
using TreeViewPoC.Core.Models;

namespace TreeViewPoC.Core.Services
{
    // This class holds sample data used by some generated pages to show how they can be used.
    // TODO WTS: Delete this file once your app is using real data.
    public static class SampleDataService
    {
        private static async Task<IEnumerable<SampleOrder>> GetAllOrdersAsync()
        {
            // The following is order summary data
            var companies = await GetDataAsync();
            return companies.SelectMany(c => c.Orders);
        }

        private static async Task<IEnumerable<SampleCompany>> GetDataAsync()
        {
            var jsonData = FileService.ReadResourceFile();
            var data = await Json.ToObjectAsync<IEnumerable<SampleCompany>>(jsonData);
            return data;
        }

        private static IEnumerable<ExplorerItem> AllFilesAndFolders()
        {
            return new ObservableCollection<ExplorerItem>()
            {
                new ExplorerItem()
                {
                    Name = "TreeViewPoC",
                    Type = ExplorerItemType.Folder,
                    Children = new ObservableCollection<ExplorerItem>()
                    {
                        new ExplorerItem()
                        {
                            Name = "Assets",
                            Type = ExplorerItemType.Folder,
                            Children = new ObservableCollection<ExplorerItem>()
                            {
                                new ExplorerItem() { Name = "LockScreenLogo.scale-200.png", Type = ExplorerItemType.File },
                                new ExplorerItem() { Name = "SplashScreen.scale-200.png", Type = ExplorerItemType.File },
                                new ExplorerItem() { Name = "Square44x44Logo.scale-200.png", Type = ExplorerItemType.File },
                            },
                        },
                        new ExplorerItem()
                        {
                            Name = "ViewModelss",
                            Type = ExplorerItemType.Folder,
                            Children = new ObservableCollection<ExplorerItem>()
                            {
                                new ExplorerItem() { Name = "MainViewModel.cs", Type = ExplorerItemType.File },
                            },
                        },
                        new ExplorerItem()
                        {
                            Name = "Views",
                            Type = ExplorerItemType.Folder,
                            Children = new ObservableCollection<ExplorerItem>()
                            {
                                new ExplorerItem() { Name = "MainView.xaml", Type = ExplorerItemType.File },
                                new ExplorerItem() { Name = "MainView.xaml.cs", Type = ExplorerItemType.File },
                            },
                        },
                    }
                },
                new ExplorerItem()
                {
                    Name = "TreeViewPoC.Core",
                    Type = ExplorerItemType.Folder,
                    Children = new ObservableCollection<ExplorerItem>()
                    {
                    },
                },
                new ExplorerItem()
                {
                    Name = "TreeViewPoC.sln",
                    Type = ExplorerItemType.File,
                },
            };
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data.
        public static async Task<IEnumerable<SampleOrder>> GetSampleModelDataAsync()
        {
            return await GetAllOrdersAsync();
        }

        public static async Task<IEnumerable<SampleCompany>> GetSampleModelCpmpaniesDataAsync()
        {
            return await GetDataAsync();
        }

        public static async Task<IEnumerable<ExplorerItem>> GetSampleFilesAndFoldersAsync()
        {

            await Task.CompletedTask;

            return AllFilesAndFolders();
        }
    }
}
