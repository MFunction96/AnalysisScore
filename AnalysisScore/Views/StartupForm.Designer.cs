namespace AnalysisScore.Views
{
    partial class StartupForm
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
            this.BtnImport = new System.Windows.Forms.Button();
            this.BtnBrowser = new System.Windows.Forms.Button();
            this.BtnAnalysis = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnImport
            // 
            this.BtnImport.Location = new System.Drawing.Point(74, 40);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(122, 39);
            this.BtnImport.TabIndex = 0;
            this.BtnImport.Text = "导入数据";
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // BtnBrowser
            // 
            this.BtnBrowser.Location = new System.Drawing.Point(238, 40);
            this.BtnBrowser.Name = "BtnBrowser";
            this.BtnBrowser.Size = new System.Drawing.Size(122, 39);
            this.BtnBrowser.TabIndex = 1;
            this.BtnBrowser.Text = "查看数据";
            this.BtnBrowser.UseVisualStyleBackColor = true;
            this.BtnBrowser.Click += new System.EventHandler(this.BtnBrowser_Click);
            // 
            // BtnAnalysis
            // 
            this.BtnAnalysis.Location = new System.Drawing.Point(398, 40);
            this.BtnAnalysis.Name = "BtnAnalysis";
            this.BtnAnalysis.Size = new System.Drawing.Size(122, 39);
            this.BtnAnalysis.TabIndex = 2;
            this.BtnAnalysis.Text = "分析数据";
            this.BtnAnalysis.UseVisualStyleBackColor = true;
            this.BtnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(238, 101);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(122, 39);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "退出";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 165);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnAnalysis);
            this.Controls.Add(this.BtnBrowser);
            this.Controls.Add(this.BtnImport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartupForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImport;
        private System.Windows.Forms.Button BtnBrowser;
        private System.Windows.Forms.Button BtnAnalysis;
        private System.Windows.Forms.Button BtnExit;
    }
}