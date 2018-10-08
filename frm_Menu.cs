using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LPR_Laptrinhvb
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_Card frm = new frm_Card();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_Statistical frm = new frm_Statistical();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_User frm = new frm_User();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_Password frm = new frm_Password();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }
    }
}
