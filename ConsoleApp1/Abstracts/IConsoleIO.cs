namespace CheckPasswordsApp.Abstracts
{
    public interface IConsoleIO
    {
        public string ReadLine();
        public void Write(string data);
    }
}
