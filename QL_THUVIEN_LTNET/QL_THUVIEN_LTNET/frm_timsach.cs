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
    public partial class frm_timsach : Form
    {
        public frm_timsach()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        private void loaddata()
        {
            DataTable dt = kn.docdulieu("select * from Sach");

            if (dt != null)
            {
                dgv_timsach.DataSource = dt;
            }
            dgv_timsach.Columns[0].HeaderText = "Mã sách ";
            dgv_timsach.Columns[0].Width = 80;
            dgv_timsach.Columns[1].Width = 150;


            dgv_timsach.Columns[1].HeaderText = "Tên sách";
            dgv_timsach.Columns[2].HeaderText = "Mã tác giả";
            dgv_timsach.Columns[2].Width = 80;
            dgv_timsach.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgv_timsach.Columns[3].Width = 80;
            dgv_timsach.Columns[4].HeaderText = "Thể loại";
            dgv_timsach.Columns[5].HeaderText = "Gía";
            dgv_timsach.Columns[6].HeaderText = "Số lượng";
            dgv_timsach.Columns[7].HeaderText = "Tình trạng";
        }
        private void frm_timsach_Load(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
           
            DataTable dt1 =  kn.docdulieu("select * from Sach where MaSach like'%"+txt_timkiem.Text+"%'");
            DataTable dt2 =  kn.docdulieu("select * from Sach where TenSach like N'%"+txt_timkiem.Text+"%'");
            if (txt_timkiem.Text =="")
            {
                loaddata();
            }
            else
            {
                if (rdb_ma.Checked == true)
                {
                    dgv_timsach.DataSource = dt1;
                }
                else
                {
                    dgv_timsach.DataSource = dt2;
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
