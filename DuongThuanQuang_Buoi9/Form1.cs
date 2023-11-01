using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace DuongThuanQuang_Buoi9
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source = A209PC38; Initial Catalog = QL_KHOA; Integrated Security = true");
        }
        private void xuat()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.Open();
                    string sql = "select * from KHOA";
                    SqlDataAdapter da = new SqlDataAdapter(sql,conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dtgv.DataSource = dt;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select count(*) from KHOA where MAKHOA = " + txt_Id.Text;
            SqlCommand cmd = new SqlCommand(sql, conn);
            int count_row = (int)cmd.ExecuteScalar();
            if(count_row == 0)
            {
                SqlCommand cmd2 = new SqlCommand("insert into KHOA values (" + txt_Id.Text + ",'" + txt_Name.Text + "')",conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                
            }
            else
            {
                MessageBox.Show("Trùng mã khoa!");
            }
            conn.Close();
        }

        private void txt_Id_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Id.Text))
                this.errorProvider1.SetError(ctrl, "Vui lòng nhập giá trị!");
            else
                this.errorProvider1.Clear();
        }

        private void txt_Name_Leave(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(txt_Name.Text))
                this.errorProvider1.SetError(ctrl, "Vui lòng nhập giá trị!");
            else
                this.errorProvider1.Clear();
        }

    }
}
