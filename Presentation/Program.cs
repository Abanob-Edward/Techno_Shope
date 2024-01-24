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
            StudentService = new StudentService(new StudentRepository(new _Context()));

            /* StudentService.Addstudent(new Student() { Name = " Abanob ", Age = 22 });
            var StdbYID = StudentService.GetStudentbyID(1);
            
             */


            Application.Run(new AdminPanal());
            //Application.Run(new LoginAndRegister());
        }
    }
}