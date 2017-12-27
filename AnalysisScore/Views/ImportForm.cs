using System.Windows.Forms;
using AnalysisScore.Controllers;
using AnalysisScore.Models;

namespace AnalysisScore.Views
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class ImportForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly Form _form;
        /// <summary>
        /// 
        /// </summary>
        private ImportController Controller { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="form"></param>
        public ImportForm(Form form)
        {
            InitializeComponent();
            _form = form;
            Controller = new ImportController();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowser_Click(object sender, System.EventArgs e)
        {
            TbFilePath.Text = Controller.SelectExcel();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, System.EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, System.EventArgs e)
        {
            _form.Show();
            Close();
        }
    }
}
