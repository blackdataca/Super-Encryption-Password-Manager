﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyId
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void UxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxCancel_Click(object sender, EventArgs e)
        {

        }

        private void uxNew_Click(object sender, EventArgs e)
        {

        }

        private void newDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void openDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
