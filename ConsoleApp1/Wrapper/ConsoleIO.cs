using CheckPasswordsApp.Abstracts;
using System;

namespace CheckPasswordsApp.Wrapper
{
    public class ConsoleIO : IConsoleIO
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string data)
        {
            Console.Write(data);
        }
    }
}
