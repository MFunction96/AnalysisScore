using AnalysisScore.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AnalysisScore.Views
{
    public partial class ExcelForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private bool ForceClose { get; set; }
        /// <summary>
        /// 
        /// </summary>
        private readonly Form _form;
        /// <summary>
        /// 
        /// </summary>
        private ExcelController Controller { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="form"></param>
        /// <param name="filePath"></param>
        public ExcelForm(Form form, string filePath)
        {
            InitializeComponent();
            _form = form;
            ForceClose = true;
            Controller = new ExcelController(filePath);
            CbSheets.DataSource = new List<string>(Controller.QuerySheets());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnImport.Enabled = await Controller.Verify();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BtnImport_Click(object sender, EventArgs e)
        {
            await Controller.Import();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            ForceClose = false;
            _form.Show();
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExcelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ForceClose) Application.Exit();
        }
    }
}
