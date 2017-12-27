using AnalysisScore.Data;
using AnalysisScore.Views;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace AnalysisScore
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<OracleDbContext>());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupForm());
        }
    }
}
