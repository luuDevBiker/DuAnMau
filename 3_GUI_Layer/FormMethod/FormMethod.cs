using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI_Layer.FormMethod
{
    public class FormMethod
    {
        public bool RegexString(TextBox textbox , string regex)
        {
            if (Regex.IsMatch(textbox.Text,regex)) ;
            {
                MessageBox.Show("Sai định dạng");
                textbox.Focus();
                return false;
            }
        }
        public bool ValidateString(TextBox textBox)
        {
            if (textBox.Text.Length == 0);
            {
                MessageBox.Show("Không được để trống thông tin");
                textBox.Focus();
                return false;
            }
        }
    }
}
