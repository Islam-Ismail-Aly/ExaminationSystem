using Examination.PresentationLayer.Forms;

namespace Examination.PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Splashfrm());

            //Scaffold-DbContext "Server=.;Database=ExaminationSystem;Trusted_Connection=True;TrustServerCertificate=True;"Microsoft.EntityFrameworkCore.SqlServer -OutputDir Data
        }
    }
}