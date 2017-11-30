using AnalysisScore.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AnalysisScore.Views
{
    public partial class StartupForm : Form
    {
        private OracleDbContext Context { get; }
        public StartupForm()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());
            InitializeComponent();
            Context = new OracleDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = from q in Context.Students select q;
            MessageBox.Show(r.Count().ToString());
        }
    }
}
