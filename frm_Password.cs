using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LPR_Laptrinhvb
{
    public partial class frm_Password : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CGPKCOT;Initial Catalog=dull;Integrated Security=True");
        public frm_Password()
        {
            InitializeComponent();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (txt_matkhau1.Text == txt_matkhau2.Text)
                {
                    cmd.CommandText = "doimatkhau";
                    cmd.Parameters.Add("@taikhoan", SqlDbType.VarChar).Value = txt_taikhoan.Text.Trim();
                    cmd.Parameters.Add("@makhaucu", SqlDbType.VarChar).Value = txt_matkhaucu.Text.Trim();
                    cmd.Parameters.Add("@matkhaumoi", SqlDbType.VarChar).Value = txt_matkhau2.Text.Trim();
                }
            else
                {
                    MessageBox.Show("Mật khẩu không khớp!", "");
                    txt_taikhoan.Text = string.Empty;
                    txt_matkhau2.Text = string.Empty;
                    txt_matkhau1.Text = string.Empty;
                    txt_matkhaucu.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
