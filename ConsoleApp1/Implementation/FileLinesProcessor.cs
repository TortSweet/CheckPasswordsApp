using CheckPasswordsApp.Abstracts;
using System;

namespace CheckPasswordsApp.Implementation
{
    public class FileLinesProcessor
    {
        private string _filePath;
        private readonly IFileService _fileService;
        private readonly ValidationCheck _check;

        public FileLinesProcessor(IFileService _fileService, ValidationCheck _check)
        {
            this._fileService = _fileService ?? throw new ArgumentNullException(nameof(_fileService), "Can't be null!");
            this._check = _check ?? throw new ArgumentNullException(nameof(_check), "Can't be null!");
        }

        public string ProcessFile(string _filePath)
        {
            if (string.IsNullOrEmpty(_filePath))
            {
                throw new ArgumentNullException(nameof(_filePath), "File path can't be null or empty");
            }

            this._filePath = _filePath;

            string[] returnedFile = _fileService.ReadFile(_filePath);

            return CycleForFile(returnedFile);
        }

        private string CycleForFile(string[] returnedFile)
        {
            if ( returnedFile == null )
            {
                return "0";
            }

            foreach (string line in returnedFile)
            {
                _check.IsValidString(line);
            }

            return _check.ShowCount().ToString();
        }
    }
}
