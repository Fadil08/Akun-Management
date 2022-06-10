using System;
using System.Drawing;
using Npgsql;
using System.Text;
using System.Windows.Forms;

namespace sisfor_akun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_MouseEnter(object sender, EventArgs e)
        {
            btnlogin.ForeColor = Color.White;
        }

        private void btnlogin_MouseLeave(object sender, EventArgs e)
        {
            btnlogin.ForeColor = Color.Black;
        }

        private void btnregis_MouseEnter(object sender, EventArgs e)
        {
            btnregis.ForeColor = Color.White;
        }

        private void btnregis_MouseLeave(object sender, EventArgs e)
        {
            btnregis.ForeColor = Color.Black;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
    }
    
}