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
        public FrmBackPass()
        {
            InitializeComponent();
        }

        private void btnsenMail_Click(object sender, EventArgs e)
        {
            try
            {
                var passRandom = utility.PassRandom();
                utility.SenderMail(txtMail.Text, passRandom);

                MessageBox.Show("done");
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
