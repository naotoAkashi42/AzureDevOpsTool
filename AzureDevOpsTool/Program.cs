using AzureDevOpsTool.View;
using AzureDevOpsTool.ViewModel;

namespace AzureDevOpsTool
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
            var agent = new MainFormAgent();
            Application.Run(new MainForm(agent));
        }
    }
}