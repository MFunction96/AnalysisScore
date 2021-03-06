﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalysisScore.Controllers;

namespace AnalysisScore.Views
{
    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public partial class BrowserForm : Form
    {
        private readonly Form _form;
        private BrowserController Controller { get; }
        /// <inheritdoc />
        /// <summary>
        /// </summary>
        /// <param name="form"></param>
        public BrowserForm(Form form)
        {
            InitializeComponent();
            _form = form;
            Controller = new BrowserController();
        }
    }
}
