using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QLCH
{
    public partial class Form1 : Form
    {
        string chuoiKN = "Data Source=.\\SQLEXPRESS;Initial Catalog=QLCH;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public void ketnoi()
        {
            try
            {
                conn = new SqlConnection(chuoiKN);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối that bai");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try {
                if (txtbusername.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập username");
                }
                else
                {
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from NGUOI_DUNG where TEN_TK=@tentk and mk=@mk";
                    cmd.Parameters.Add("@tentk", SqlDbType.NVarChar).Value = txtbusername.Text;
                    cmd.Parameters.Add("@mk", SqlDbType.NVarChar).Value = txtbpass.Text;
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Columns.Add("TEN_TK", typeof(string));
                    dt.Columns.Add("MK", typeof(string));
                    dt.Columns.Add("MUC_DO", typeof(int));
                    dt.Load(dr);
                    if (dt.Rows[0][0] != null)
                    {
                        this.Hide();
                        Formql form2 = new Formql();
                        form2.ShowDialog();
                        this.Close();
                    }

                    int i = cmd.ExecuteNonQuery();
                    //      if (i > 0) MessageBox.Show("Thanh cong aaa");
                    //    else MessageBox.Show("Loi"+i);
                    conn.Close();
                    cmd.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên hoặc mật khẩu không đúng");
            }

        }
    }
}
