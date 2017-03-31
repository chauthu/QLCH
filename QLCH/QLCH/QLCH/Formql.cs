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
    public partial class Formql : Form
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
        public Formql()
        {
            InitializeComponent();
        }

        private void Formql_Load(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from NHANVIEN ";
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dtgrid1.DataSource = dt;

                cmd.CommandText = "select * from Ca ";
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dtgridca.DataSource = dt;
                conn.Close();
                cmd.Dispose();


            } catch (Exception EX) { }
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtbmanv.Text == "")//tim theo ten
                {
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from NHANVIEN where TEN_NV like '%" + txtbtennv.Text + "%' ";
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dtgrid1.DataSource = dt;
                    conn.Close();
                    cmd.Dispose();
                }
                else
                {
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from NHANVIEN where MA_NV='" + txtbmanv.Text + "'";
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dtgrid1.DataSource = dt;
                    conn.Close();
                    cmd.Dispose();
                }
            }catch(Exception ex) { }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "insert into NHANVIEN values(@manv,@tennv,@luong,@sodt,@diachi)";
                cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = txtbthemmanv.Text;
                cmd.Parameters.Add("@tennv", SqlDbType.NVarChar).Value = txtbthemtennv.Text;
                cmd.Parameters.Add("@luong", SqlDbType.Int).Value = txtbthemluong.Text;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = txtbthemdienthoai.Text;
                cmd.Parameters.Add("@sodt", SqlDbType.NVarChar).Value = txtbthemdiachi.Text;
                int i = cmd.ExecuteNonQuery();
                if (i > 0) MessageBox.Show("Thành công");
                 else MessageBox.Show("Lỗi");
                conn.Close();
                cmd.Dispose();
            }
            catch(Exception ex) { }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from NHANVIEN where MA_NV='" + txtbmanv.Text + "'";
                int i = cmd.ExecuteNonQuery();
                if (i > 0) MessageBox.Show("Thành công");
                else MessageBox.Show("Lỗi");
                conn.Close();
                cmd.Dispose();
            }
            catch(Exception ex) { }
        }

        private void btntimca_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbcamanv.Text == "")//tim theo ten
                {
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select NHANVIEN.MA_NV,TEN_NV,CA.SO_CA,THU,TG from ((CHITIETCA_NV INNER JOIN NHANVIEN on NHANVIEN.MA_NV=CHITIETCA_NV.MA_NV) inner join CA_NV on CHITIETCA_NV.MA_CA=CA_NV.MA_CA)inner join CA on CA_NV.SO_CA=CA.SO_CA where NHANVIEN.TEN_NV like'%"+txtbcaTennv.Text+"%'";

                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dtgridcanv.DataSource = dt;
                    conn.Close();
                    cmd.Dispose();
                }
                else
                {
                    ketnoi();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "select * from NHANVIEN where MA_NV='" + txtbmanv.Text + "'";
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dtgrid1.DataSource = dt;
                    conn.Close();
                    cmd.Dispose();
                }
            }
            catch(Exception ex) { }
        }
    }
}
