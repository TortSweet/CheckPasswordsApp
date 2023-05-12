namespace CheckPasswordsApp.Abstracts
{
    public interface IFileService
    {
        public string[] ReadFile(string filePath);
    }
}
