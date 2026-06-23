using System;
using System.IO;
namespace Kowoon.Utils
{
    internal class FileManager
    {
        private static readonly Lazy<FileManager> _lazy = new Lazy<FileManager>(() => new FileManager());
        public static FileManager GetInstance => _lazy.Value;

        private const string _resourceDirectoryName = "resource";

        private FileManager()
        {
            CreateDirectorys(_resourceDirectoryName);
        }

        private string CurrentPath()
        {
            return Environment.CurrentDirectory;
        }

        public string GetResourceDirectoryPath()
        {
            return CurrentPath() + "\\" + _resourceDirectoryName;
        }

        public void CreateDirectorys(string directoryName)
        {
            string currentPath = CurrentPath();
            string currentPathDrive = currentPath.Substring(0, 3);
            string myPath = currentPath + "\\" + directoryName;
            if (directoryName.IndexOf(@"C:\") >= 0 || directoryName.IndexOf(currentPathDrive) >= 0)
            {
                myPath = directoryName;
            }
            if (!Directory.Exists(myPath))
            {
                Directory.CreateDirectory(myPath);
            }
        }

        public void CreateFile(string directoryName, string fileName)
        {
            string currentPath = CurrentPath();
            string currentPathDrive = currentPath.Substring(0, 3);
            string path = currentPath + "\\" + directoryName;
            if (directoryName.IndexOf(@"C:\") >= 0 || directoryName.IndexOf(currentPathDrive) >= 0)
            {
                path = directoryName;
            }
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string file = path + "\\" + fileName;
            if (!File.Exists(fileName))
            {
                File.Create(file);
            }
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
