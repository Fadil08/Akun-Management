using System;
using Npgsql;
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
    public partial class logo : Form
    {
        public logo()
        {
            InitializeComponent();
        }


        private void home_MouseEnter(object sender, EventArgs e)
        {
            home.ForeColor = Color.Black;
        }

        private void home_MouseLeave(object sender, EventArgs e)
        {
            home.ForeColor = Color.White;
        }

        private void notes_MouseEnter(object sender, EventArgs e)
        {
            notes.ForeColor=Color.Black;
        }

        private void notes_DragLeave(object sender, EventArgs e)
        {
            notes.ForeColor = Color.White;
        }

        private void show_DragEnter(object sender, DragEventArgs e)
        {
            show.ForeColor = Color.Black;
        }

        private void show_DragLeave(object sender, EventArgs e)
        {
            show.ForeColor = Color.White;
        }

        private void akun_DragEnter(object sender, DragEventArgs e)
        {
            akun.ForeColor = Color.Black;
        }

        private void akun_DragLeave(object sender, EventArgs e)
        {
            akun.ForeColor = Color.White;
        }

        private void closeN_DragEnter(object sender, DragEventArgs e)
        {
            closeN.ForeColor = Color.Red;
        }

        private void closeN_DragLeave(object sender, EventArgs e)
        {
            closeN.ForeColor = Color.White;
        }
    }
}
