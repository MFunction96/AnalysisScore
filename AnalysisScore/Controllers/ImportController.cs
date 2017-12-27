using AnalysisScore.Properties;
using System.Windows.Forms;

namespace AnalysisScore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportController
    {
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
