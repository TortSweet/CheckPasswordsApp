using CheckPasswordsApp.Abstracts;
using CheckPasswordsApp.Implementation;
using CheckPasswordsApp.Wrapper;
using Microsoft.Extensions.DependencyInjection;

namespace CheckPasswordsApp
{
    public class Program
    {
        public static void Main()
        {
            var newValidator = new ValidationCheck();

            var newService = new ServiceCollection()
                .AddSingleton<IFileService, FileService>()
                .AddSingleton<IConsoleIO, ConsoleIO>()
                .AddSingleton<FileLinesProcessor>()
                .AddSingleton<ValidationCheck>()
                .AddSingleton<ProgramManager>()
                .BuildServiceProvider();


            var newProgManager = newService.GetRequiredService<ProgramManager>();
            newProgManager.Start();
        }
    }
}
