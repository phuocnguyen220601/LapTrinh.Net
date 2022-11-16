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
    public partial class frm_tguser : Form
    {
        public frm_tguser()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = kn.docdulieu("select * from TacGia");

            if (dt != null)
            {
                dgv_tguser.DataSource = dt;
            }
            dgv_tguser.Columns[0].HeaderText = "Mã tác giả ";
            dgv_tguser.Columns[0].Width = 100;
            dgv_tguser.Columns[1].Width = 180;


            dgv_tguser.Columns[1].HeaderText = "Tên tác giả";
            dgv_tguser.Columns[2].HeaderText = "Ngày sinh";
            dgv_tguser.Columns[2].Width = 100;
            dgv_tguser.Columns[3].HeaderText = "Gioi tính";
            dgv_tguser.Columns[3].Width = 100;
            dgv_tguser.Columns[4].HeaderText = "Email";
            dgv_tguser.Columns[4].Width = 180;
            dgv_tguser.Columns[5].HeaderText = "Số điện thoại";

        }
        private void frm_tguser_Load(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text == "")
            {
                loaddata();
            }    else
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt1 = kn.docdulieu("Select * from TacGia where Tentg like N'%" + txt_timkiem.Text+"'");
                dt2 = kn.docdulieu("Select * from TacGia where Matg like N'%" + txt_timkiem.Text+"'");
                if (rdb_matg.Checked == true)
                {
                    dgv_tguser.DataSource = dt1;

                }   else
                {
                    dgv_tguser.DataSource = dt2;
                }                    
                
            }    
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rdb_matg_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_user f = new frm_user();
            f.Show();
        }
    }
}
