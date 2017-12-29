namespace AnalysisScore.Views
{
    partial class ExcelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbSheets = new System.Windows.Forms.ComboBox();
            this.DgvSheet = new System.Windows.Forms.DataGridView();
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // CbSheets
            // 
            this.CbSheets.FormattingEnabled = true;
            this.CbSheets.Location = new System.Drawing.Point(35, 24);
            this.CbSheets.Name = "CbSheets";
            this.CbSheets.Size = new System.Drawing.Size(421, 23);
            this.CbSheets.TabIndex = 0;
            this.CbSheets.SelectedIndexChanged += new System.EventHandler(this.CbSheets_SelectedIndexChanged);
            // 
            // DgvSheet
            // 
            this.DgvSheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSheet.Location = new System.Drawing.Point(35, 66);
            this.DgvSheet.Name = "DgvSheet";
            this.DgvSheet.RowTemplate.Height = 27;
            this.DgvSheet.Size = new System.Drawing.Size(710, 362);
            this.DgvSheet.TabIndex = 1;
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(488, 24);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(110, 23);
            this.BtnImport.TabIndex = 2;
            this.BtnImport.Text = "导入数据";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(635, 24);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(110, 23);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "返回控制台";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 464);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.DgvSheet);
            this.Controls.Add(this.CbSheets);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExcelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CbSheets;
        private System.Windows.Forms.DataGridView DgvSheet;
        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnReturn;
    }
}