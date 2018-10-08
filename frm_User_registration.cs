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
    public partial class frm_User_registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CGPKCOT;Initial Catalog=dull;Integrated Security=True");
        public frm_User_registration()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                if (txt_matkhau1.Text == txt_matkhau2.Text)
                {
                    cmd.CommandText = "themnguoidung";
                    cmd.Parameters.Add("@ID_nguoidung", SqlDbType.VarChar).Value = txt_manhanvien.Text.Trim();
                    cmd.Parameters.Add("@tennguoidung", SqlDbType.NVarChar).Value = txt_hovaten.Text.Trim();
                    cmd.Parameters.Add("@CMTND", SqlDbType.Int).Value = Int32.Parse(txt_CMTND.Text.Trim());
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = dtp_ngaysinh.Value;
                    cmd.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = txt_taikhoan.Text.Trim();
                    cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = txt_matkhau2.Text.Trim();
                    cmd.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = Int32.Parse(txt_sodienthoai.Text.Trim());
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txt_diachi.Text.Trim();
                    if (cbo_chucvu.Text == "Kiểm soát vé")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "1";
                        cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    else if (cbo_chucvu.Text == "Quản trị viên")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "2";
                        cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    else if (cbo_chucvu.Text == "Quản lý")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "3";
                        cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!", "");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không khớp!", "");
                    txt_manhanvien.Text = string.Empty;
                    txt_hovaten.Text = string.Empty;
                    txt_CMTND.Text = string.Empty;
                    txt_sodienthoai.Text = string.Empty;
                    txt_matkhau2.Text = string.Empty;
                    txt_matkhau1.Text = string.Empty;
                    txt_diachi.Text = string.Empty;
                    dtp_ngaysinh.Value = DateTime.Now;
                    cbo_chucvu.SelectedIndex = 0;
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
