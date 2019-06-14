using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TreeViewPoC.Core.Services
{
    public static class FileService
    {
        public static string ReadResourceFile()
        {
            string file;
            var assembly = typeof(FileService).GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream("TreeViewPoC.Core.Data.SampleData.json"))
            {
                using (var reader = new StreamReader(stream))
                {
                    file = reader.ReadToEnd();
                }
            }

            return file;
        }
    }
}
