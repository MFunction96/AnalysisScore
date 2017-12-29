using System.Windows.Forms;
using AnalysisScore.Data;
using AnalysisScore.Properties;

namespace AnalysisScore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class StartupController
    {
        /// <summary>
        /// 
        /// </summary>
        public OracleDbContext Context => new OracleDbContext();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string SelectExcel()
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = Resources.ExcelFileType,
                Title = Resources.PickFileTitle
            };
            dialog.ShowDialog();
            return dialog.FileName;
        }
    }
}
