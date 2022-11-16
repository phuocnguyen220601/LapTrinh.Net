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
    public partial class frm_phieumuonuser : Form
    {
        string strNhandl;
        public frm_phieumuonuser()
        {
            InitializeComponent();
          
        }

        public frm_phieumuonuser(string strNhan) :this()
        {
            strNhandl = strNhan;
        }

        ketnoi kn = new ketnoi();
  
        public void loaddata()
        {
            
            String id_dg;
                DataTable dt = new DataTable();
            dt = kn.docdulieu("select * from DocGia where Username like N'%"+strNhandl+"'");
            for(int i =0;i< dt.Rows.Count; i++)
            {
                id_dg = dt.Rows[i]["MaDG"].ToString();
                DataTable dt1 = new DataTable();
                dt1 = kn.docdulieu("select * from PhieuMuon where MaDG like N'%"+id_dg+"'");
                dgv_phieumuon.DataSource = dt1;
                dgv_phieumuon.Columns[0].HeaderText = "Ma PM";
                dgv_phieumuon.Columns[0].Width = 90;
                dgv_phieumuon.Columns[1].HeaderText = "Ma sách";
                dgv_phieumuon.Columns[1].Width = 90;
                dgv_phieumuon.Columns[2].HeaderText = "Ma độc giả";
                dgv_phieumuon.Columns[2].Width = 90;
                dgv_phieumuon.Columns[3].HeaderText = "Ma nhân viên";
                dgv_phieumuon.Columns[3].Width = 90;
                dgv_phieumuon.Columns[4].HeaderText = "Ngày mượn";
                dgv_phieumuon.Columns[4].Width = 200;
                dgv_phieumuon.Columns[5].HeaderText = "Ngày trả";
                dgv_phieumuon.Columns[5].Width = 200;
                DataTable dt2 = new DataTable();
                dt2 = kn.docdulieu("select * from PhieuMuon where MaDG like N'%"+id_dg+ "' and NgayTra < GETDATE()");
                if(dt2 != null)
                {
                    MessageBox.Show("Ban có phiếu mươn đã hết hạn!Vui lòng đến thư viện để gia hạn hoặc trả sách !", "Thông báo");
                }else
                {
                    MessageBox.Show("Loi", "Thông báo");
                }    
            }    
        }
        private void frm_phieumuonuser_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
