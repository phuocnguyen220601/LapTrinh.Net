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
    public partial class frm_sachuser : Form
    {
        public frm_sachuser()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("Select * from Sach");
            if(dt != null)
            {
                dgv_sachuser.DataSource = dt;
            }
            dgv_sachuser.Columns[0].HeaderText = "Mã sách ";
            dgv_sachuser.Columns[0].Width = 80;
            dgv_sachuser.Columns[1].Width = 150;


            dgv_sachuser.Columns[1].HeaderText = "Tên sách";
            dgv_sachuser.Columns[2].HeaderText = "Mã tác giả";
            dgv_sachuser.Columns[2].Width = 80;
            dgv_sachuser.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgv_sachuser.Columns[3].Width = 80;
            dgv_sachuser.Columns[4].HeaderText = "Thể loại";
            dgv_sachuser.Columns[6].HeaderText = "Gía";
            dgv_sachuser.Columns[5].HeaderText = "Số lượng";
            dgv_sachuser.Columns[7].HeaderText = "Tình trạng";

        }
        private void frm_sachuser_Load(object sender, EventArgs e)
        {

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(txt_timkiem.Text =="")
            {
                loaddata();
            }    
            else
            {
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                dt1 = kn.docdulieu("Select * from Sach where TenSach like N'%" +txt_timkiem.Text+"'");
                if(rdb_tensach.Checked == true)
                {
                    dgv_sachuser.DataSource = dt1;
                }    else
                {
                    dt2 = kn.docdulieu("Select * from TacGia where TenTg like N'%"+txt_timkiem.Text+"'");
                    String ID_TG;
                    for(int i=0;i< dt2.Rows.Count;i++)
                    {
                        ID_TG = dt2.Rows[i]["Matg"].ToString();
                        DataTable dt3 = new DataTable();
                        dt3 = kn.docdulieu("Select * from Sach where Matg like '%"+ID_TG+"'");
                        dgv_sachuser.DataSource = dt3;
                    }    
                }    
            }    
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_user f = new frm_user();
            f.Show();
        }
    }
}
