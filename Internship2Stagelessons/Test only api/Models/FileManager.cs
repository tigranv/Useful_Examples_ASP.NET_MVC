using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Test_only_api.Models
{
    public class FileManager
    {
        public static IEnumerable<string> GetAllFiles()
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\TestDirectory");
            var files = directory.GetFiles().Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden)).Select(f => f.Name).ToArray();
            return files;
        }

        public static string GetFileByName(string name)
        {
            DirectoryInfo directory = new DirectoryInfo(@"D:\TestDirectory");
            string path = Path.Combine(@"D:\TestDirectory", name);
            StreamReader sr = File.OpenText(path);
            string textline = sr.ReadLine();
            sr.Close();
            return textline;
        }
    }
}