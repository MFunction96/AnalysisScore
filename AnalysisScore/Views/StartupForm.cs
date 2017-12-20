using AnalysisScore.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AnalysisScore.Views
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class StartupForm : Form
    {
        private OracleDbContext Context { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        public StartupForm()
        {
            InitializeComponent();
            Context = new OracleDbContext();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            var r = from q in Context.Scores select q;
            MessageBox.Show(r.Count().ToString());
        }
    }
}
