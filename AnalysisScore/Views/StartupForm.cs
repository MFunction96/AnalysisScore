using AnalysisScore.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using AnalysisScore.Controllers;

namespace AnalysisScore.Views
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class StartupForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public StartupController Controller { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public StartupForm()
        {
            InitializeComponent();
            Controller = new StartupController();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var filepath = Controller.SelectExcel();
            var form = new ExcelForm(this, filepath);
            Hide();
            form.Show();
        }

        private void BtnBrowser_Click(object sender, EventArgs e)
        {
            var form = new BrowserForm(this);
            Hide();
            form.Show();
        }

        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            var form = new AnalysisForm(this);
            Hide();
            form.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
