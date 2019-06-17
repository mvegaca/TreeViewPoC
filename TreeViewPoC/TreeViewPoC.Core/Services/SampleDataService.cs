using System;
using System.Collections.Generic;
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

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data.
        public static async Task<IEnumerable<SampleOrder>> GetSampleModelDataAsync()
        {
            return await GetAllOrdersAsync();
        }

        public static async Task<IEnumerable<SampleCompany>> GetCompaniesDataAsync()
        {
            return await GetDataAsync();
        }
    }
}
