using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_THUVIEN_LTNET
{
    public partial class frm_timdocgia : Form
    {
        public frm_timdocgia()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("SELECT * FROM DocGia");
            if (dt != null)
            {
                dgv_timdg.DataSource = dt;
            }
            dgv_timdg.Columns[0].HeaderText = "Ma DG";
            dgv_timdg.Columns[1].HeaderText = "Ten DG";
            dgv_timdg.Columns[2].HeaderText = "Username";
            dgv_timdg.Columns[3].HeaderText = "Password";
            dgv_timdg.Columns[4].HeaderText = "Gioi tính";
            dgv_timdg.Columns[5].HeaderText = "Địa chỉ";
            dgv_timdg.Columns[6].HeaderText = "Ngày sinh";
            dgv_timdg.Columns[7].HeaderText ="SDT";
            dgv_timdg.Columns[8].HeaderText ="Quyền";


        }
        private void frm_timdocgia_Load(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            DataTable dt1 = kn.docdulieu("select * from DocGia where MaDG like'%"+txt_timkiem.Text+"%'");
            DataTable dt2 = kn.docdulieu("select * from DocGia where HoTen like N'%"+txt_timkiem.Text+"%'");
            if (txt_timkiem.Text =="")
            {
                loaddata();
            }
            else
            {
                if (rdb_ma.Checked == true)
                {
                    dgv_timdg.DataSource = dt1;
                }
                else
                {
                    dgv_timdg.DataSource = dt2;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Admin f = new frm_Admin();
            f.Show();
        }
    }
}
