using Appliaction.Services;
using Context;
using Infrastructure.Repositores;
using Model.Models;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
    
        static IStudentService? StudentService;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
           // StudentService = new StudentService(new StudentRepository(new _Context()));

       


            Application.Run(new LoginAndRegister());
            //Application.Run(new LoginAndRegister());
        }
    }
}