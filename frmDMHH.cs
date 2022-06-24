using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LopPTUD2022_sang
{
    public partial class frmDMHH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public frmDMHH()
        {
            InitializeComponent();
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmDMHH_Load(object sender, EventArgs e)
        {
            constr = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            //Lấy dữ liệu 
            sql = "Select MaNhom, TenHH, MaHH, Dvt, Dgvnd, sanxuat from tblDMHH";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdData.DataSource = dt;
            NapCT();

        }
        private void NapCT()
        {
            //ban ghi hien thoi
            i = grdData.CurrentRow.Index;// i chua so thu tu cua ban ghi hien thoi
            txtMaNhom.Text = grdData.Rows[i].Cells["MaNhom"].Value.ToString();
            txtMaHH.Text= grdData.Rows[i].Cells["MaHH"].Value.ToString();
            txtTenHH.Text= grdData.Rows[i].Cells["TenHH"].Value.ToString();
            txtdvt.Text= grdData.Rows[i].Cells["dvt"].Value.ToString();
            txtDgvnd.Text= grdData.Rows[i].Cells["Dgvnd"].Value.ToString();
            txtsanxuat.Text= grdData.Rows[i].Cells["sanxuat"].Value.ToString();
            // ten ô lưới, value, tostring: chuyển sang dạng text
            // cách lấy dự liệu ra từ dòng i lấy tên chỉ định từ 1 ô lưới 
        }
            
    }
}
