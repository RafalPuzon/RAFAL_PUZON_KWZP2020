﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP_LAB_Winform
{
    public partial class lbl1 : Form
    {
        public lbl1()
        {
            InitializeComponent();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            btn1.Enabled = chk1.Checked;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if(txt1.TextLength > 0)
            {
                btn1.Text = txt1.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DetailsForm detailsForm = new DetailsForm(txt1.Text);
            detailsForm.Show();
        }
    }
}
