using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using _2_BUS_Layer.Utility;
namespace _3_GUI_Layer
{
    public partial class FrmBackPass : Form
    {
        private utility utility = new utility();
        private string _mail;
        public FrmBackPass()
        {
            InitializeComponent();
        }

        private void getMail(string mail)
        {
            _mail = mail;
        }

        private void btnsenMail_Click(object sender, EventArgs e)
        {
 
            MessageBox.Show("done");
        }
    }
}
