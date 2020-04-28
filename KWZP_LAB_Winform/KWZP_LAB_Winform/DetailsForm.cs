using System;
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
    public partial class DetailsForm : Form
    {
        public DetailsForm(String labelText)
        {
            InitializeComponent();
            lbl2.Text = labelText;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
