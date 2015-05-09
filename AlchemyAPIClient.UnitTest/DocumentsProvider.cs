using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchemyAPIClient.UnitTest
{
    public class DocumentsProvider
    {
        public static Lazy<List<string>> Documents = new Lazy<List<string>>(() =>
        {
            var _documents = new List<string>();
            var filePaths = Directory.EnumerateFiles(".\\Documents\\", "*.txt");
            foreach (var filePath in filePaths)
            {
                _documents.Add(File.ReadAllText(filePath, Encoding.UTF8));
            }
            return _documents;
        });
    }
}
