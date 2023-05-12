using CheckPasswordsApp.Abstracts;
using System;
using System.IO;

namespace CheckPasswordsApp.Wrapper
{
    public class FileService : IFileService
    {
        public string[] ReadFile(string filePath)
        {
            if (File.Exists(filePath) == false)
            {
                throw new FileNotFoundException(nameof(filePath), "File from this path is not exist!");
            }
            if (String.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentNullException(nameof(filePath), "Path to the file can't be empty!");
            }
            return File.ReadAllLines(filePath);
        }
    }
}
