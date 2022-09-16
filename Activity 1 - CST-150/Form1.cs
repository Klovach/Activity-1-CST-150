using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_1___CST_150
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rtx_about_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmation_Click(object sender, EventArgs e)
        {
            lbl_confirmation.Text = "Thank you for answering the form.";
        }
    }
}
