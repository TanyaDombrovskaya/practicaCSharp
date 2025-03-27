using System.IO;

namespace FileNamespace
{
    public class FileManager
    {
        private string _path;

        public FileManager(string path)
        {
            _path = path;
        }

        public void CreateFile()
        {
            using (FileStream fs = File.Create(_path)) { }
        }

        public void DeleteFile()
        {
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }
        }

        public void CopyFile(string copyPath)
        {
            if (File.Exists(_path))
            {
                File.Copy(_path, copyPath, true);
            }
        }

        public void MoveFile(string newPath)
        {
            if (File.Exists(_path))
            {
                File.Move(_path, newPath);
            }
        }
    }
}
