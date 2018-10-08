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
    public partial class frm_User : Form
    {
        int button = 0;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-CGPKCOT;Initial Catalog=dull;Integrated Security=True");
        public frm_User()
        {
            InitializeComponent();
            btn_luu.Enabled = false;
            //dataGridView1.Enabled = false;
            ketnoicsdl();
            txt_manguoidung.Enabled = false;
            txt_hovaten.Enabled = false;
            txt_cmtnd.Enabled = false;
            txt_sodienthoai.Enabled = false;
            txt_diachi.Enabled = false;
            txt_taikhoan.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            cbo_chucvu.Enabled = false;
        }

        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select a.ID_nguoidung,a.tennguoidung,b.taikhoan,a.ngaysinh,a.chucvu,a.CMTND,a.sodienthoai,a.diachi from TBL_nguoidung as a, TBL_taikhoan as b where a.ID_nguoidung=b.ID_nguoidung";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void btn_dangkynguoidung_Click(object sender, EventArgs e)
        {
            frm_User_registration frm = new frm_User_registration();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_manguoidung.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            txt_hovaten.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            txt_taikhoan.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            dtp_ngaysinh.Value = Convert.ToDateTime(dataGridView1.Rows[numrow].Cells[3].Value);
            cbo_chucvu.Text = dataGridView1.Rows[numrow].Cells[4].Value.ToString();
            txt_cmtnd.Text = dataGridView1.Rows[numrow].Cells[5].Value.ToString();
            txt_sodienthoai.Text = dataGridView1.Rows[numrow].Cells[6].Value.ToString();
            txt_diachi.Text = dataGridView1.Rows[numrow].Cells[7].Value.ToString();
        }

        private void btn_suathongtinguoidung_Click(object sender, EventArgs e)
        {
            txt_manguoidung.Enabled = false;
            txt_hovaten.Enabled = true;
            txt_cmtnd.Enabled = true;
            txt_sodienthoai.Enabled = true;
            txt_diachi.Enabled = true;
            txt_taikhoan.Enabled = false;
            dtp_ngaysinh.Enabled = true;
            cbo_chucvu.Enabled = true;
            button = 1;
        }

        private void btn_xoathongtinnguoidung_Click(object sender, EventArgs e)
        {
            button = 2;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (button == 1)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "suanguoidung";
                    cmd.Parameters.Add("@ID_nguoidung", SqlDbType.VarChar).Value = txt_manguoidung.Text.Trim();
                    cmd.Parameters.Add("@tennguoidung", SqlDbType.NVarChar).Value = txt_hovaten.Text.Trim();
                    cmd.Parameters.Add("@CMTND", SqlDbType.Int).Value = Int32.Parse(txt_cmtnd.Text.Trim());
                    cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = dtp_ngaysinh.Value;
                    cmd.Parameters.Add("@sodienthoai", SqlDbType.Int).Value = Int32.Parse(txt_sodienthoai.Text.Trim());
                    cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txt_diachi.Text.Trim();
                    if (cbo_chucvu.Text == "Kiểm soát vé")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "1";
                        cmd.Parameters.Add("@vaitro", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    else if (cbo_chucvu.Text == "Quản trị viên")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "2";
                        cmd.Parameters.Add("@vaitro", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    else if (cbo_chucvu.Text == "Quản lý")
                    {
                        cmd.Parameters.Add("@quyen", SqlDbType.VarChar).Value = "3";
                        cmd.Parameters.Add("@vaitro", SqlDbType.NVarChar).Value = cbo_chucvu.Text.Trim();
                    }
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            else if (button == 2)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "xoanguoidung";
                    cmd.Parameters.Add("@ID_nguoidung", SqlDbType.VarChar).Value = txt_manguoidung.Text.Trim();
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            txt_manguoidung.Text = string.Empty;
            txt_hovaten.Text = string.Empty;
            txt_cmtnd.Text = string.Empty;
            txt_sodienthoai.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            dtp_ngaysinh.Value = DateTime.Now;
            cbo_chucvu.SelectedIndex = 0;

            txt_manguoidung.Enabled = false;
            txt_hovaten.Enabled = false;
            txt_cmtnd.Enabled = false;
            txt_sodienthoai.Enabled = false;
            txt_diachi.Enabled = false;
            dtp_ngaysinh.Enabled = false;
            cbo_chucvu.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(cbo_timkiem.Text == "Mã người dùng")
            {
                con.Open();
                string sql = "select a.ID_nguoidung,a.tennguoidung,b.taikhoan,a.ngaysinh,a.chucvu,a.CMTND,a.sodienthoai,a.diachi from TBL_nguoidung as a, TBL_taikhoan as b where a.ID_nguoidung=b.ID_nguoidung and a.ID_nguoidung LIKE'%"+txt_timkiem.Text+"%'";  // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                con.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            else if(cbo_timkiem.Text == "Họ và tên")
            {
                con.Open();
                string sql = "select a.ID_nguoidung,a.tennguoidung,b.taikhoan,a.ngaysinh,a.chucvu,a.CMTND,a.sodienthoai,a.diachi from TBL_nguoidung as a, TBL_taikhoan as b where a.ID_nguoidung=b.ID_nguoidung and a.tennguoidung LIKE N'%"+txt_timkiem.Text+"%'";  // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                con.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            }
            else if(cbo_timkiem.Text == "Tài khoản")
            {
                con.Open();
                string sql = "select a.ID_nguoidung,a.tennguoidung,b.taikhoan,a.ngaysinh,a.chucvu,a.CMTND,a.sodienthoai,a.diachi from TBL_nguoidung as a, TBL_taikhoan as b where a.ID_nguoidung=b.ID_nguoidung and b.taikhoan LIKE N'%"+txt_timkiem.Text+"%'";  // lay het du lieu trong bang sinh vien
                SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
                DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
                da.Fill(dt);  // đổ dữ liệu vào kho
                con.Close();  // đóng kết nối
                dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
            } 
        }
       
    }
}
