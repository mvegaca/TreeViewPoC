﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TreeViewPoC.Core.Models;
using TreeViewPoC.Core.Services;
using TreeViewPoC.Helpers;

namespace TreeViewPoC.ViewModels
{
    public class MainViewModel : Observable
    {
        public ObservableCollection<ExplorerItem> DataSource { get; } = new ObservableCollection<ExplorerItem>();

        public MainViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            var data = await SampleDataService.GetSampleFilesAndFoldersAsync();
            foreach (var item in data)
            {
                DataSource.Add(item);
            }
        }
    }
}
