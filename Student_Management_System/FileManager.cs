using System;
using System.IO;

namespace Student_Management_System
{
    public class FileManager
    {
        private readonly string filePath;

        public FileManager(string fileName = "course_data.txt")
        {
            filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
        }

        public void SaveToFile(string data)
        {
            File.AppendAllText(filePath, data + Environment.NewLine);
        }

        public string ReadFromFile()
        {
            return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
        }
    }
}
