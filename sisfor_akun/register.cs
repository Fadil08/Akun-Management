using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sisfor_akun
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }


        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor=Color.Blue;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }


    }
}
