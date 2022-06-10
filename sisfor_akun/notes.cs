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
    public partial class notes : Form
    {
        public notes()
        {
            InitializeComponent();
        }

        private void closeN_DragEnter(object sender, DragEventArgs e)
        {
            closeN.ForeColor = Color.Red;closeN.BackColor = Color.Green;
        }
    }
}
