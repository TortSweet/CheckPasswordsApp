using CheckPasswordsApp.Abstracts;
using System;

namespace CheckPasswordsApp.Implementation
{
    public class ProgramManager
    {
        private readonly IConsoleIO _console;
        private readonly FileLinesProcessor _fileProcessor;

        public ProgramManager(IConsoleIO _console, FileLinesProcessor _fileProcessor)
        {
            this._console = _console ?? throw new ArgumentNullException(nameof(_console), "Can't be null!");
            this._fileProcessor = _fileProcessor ?? throw new ArgumentNullException(nameof(_fileProcessor), "Can't be null!");
        }
        public void Start()
        {
            var userInput = GetUserInputPath();
            var result = _fileProcessor.ProcessFile(userInput);

            PrintResult(result);
        }

        public void PrintResult(string result)
        {
            if (result == null)
            {
                throw new ArgumentNullException(nameof(result), "Result can't be null!");
            }
            _console.Write(Constants.ResultMessage + result.ToString());
        }
        private string GetUserInputPath()
        {
            _console.Write(Constants.EnterFilePath);

            string filePathInput = _console.ReadLine();

            if (string.IsNullOrWhiteSpace(filePathInput))
            {
                _console.Write(Constants.UserInputIsEmpty);
                Console.ReadKey();
                Console.Clear();
                GetUserInputPath();
            }

            return $@"{filePathInput}";
        }
    }

}
