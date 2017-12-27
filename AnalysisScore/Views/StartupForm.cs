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
        public static StartupController Controller => new StartupController();
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public StartupForm()
        {
            InitializeComponent();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var form = new ImportForm(this);
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
