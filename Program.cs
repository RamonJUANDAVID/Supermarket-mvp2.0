using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.Properties;
using Supermarket_mvp.Views;
using System.Configuration;

namespace Supermarket_mvp
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
            string sqlConecctionString = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConecctionString);
            Application.Run((Form) view);

        }
    }
}