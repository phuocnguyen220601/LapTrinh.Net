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
    public partial class frm_user : Form
    {
        string strNhan;
        String ID_DG;
        public frm_user()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        public frm_user(string text) :this()
        {
            strNhan  =text;
            
        }

        public string Message
        {
            get { return strNhan; }
            set { strNhan = value; }
        }
        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_phieumuonuser f = new frm_phieumuonuser(strNhan);
            f.Show();
        }

        private void frm_user_Load(object sender, EventArgs e)
        {
            
        }
        public void loaddata2()
        {
           
            DataTable dt = new DataTable();
            dt = kn.docdulieu("select * from DocGia where Username like N'%"+strNhan+"'");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txt_name.Text = dt.Rows[i]["HoTen"].ToString();
                cb_gt.Text = dt.Rows[i]["GioiTinh"].ToString();
                txt_diachi.Text = dt.Rows[i]["Diachi"].ToString();
                dtp_ns.Text = dt.Rows[i]["NamSinh"].ToString();
                txt_sdt.Text = dt.Rows[i]["SDT"].ToString();
                ID_DG = dt.Rows[i]["MaDG"].ToString();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            loaddata2();
        }

        private void btn_capnhap_Click(object sender, EventArgs e)
        {
            txt_sdt.Enabled = true;
            txt_name.Enabled = true;
            cb_gt.Enabled = true;
            txt_diachi.Enabled = true;
            dtp_ns.Enabled = true;
        }

        private void btn_thoát_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text ==""||txt_sdt.Text==""||txt_diachi.Text==""||cb_gt.Text==""||dtp_ns.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin", "Thông báo");
            }
            else
            {
                String sql2 = "update  DocGia set HoTen=N'"+ txt_name.Text + "',GioiTinh =N'"+cb_gt.Text+"',DiaChi =N'"+txt_diachi.Text+"',NamSinh =N'"+dtp_ns.Text+"',SDT = '"+txt_sdt.Text+"'  where Username=N'" + strNhan + "'";
                if (kn.thucthidulieu(sql2)==true)
                {
                    MessageBox.Show("Cập nhập thông tin thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi", "Thông báo");
                }
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_login frm_Login = new frm_login();
            frm_Login.Show();
            
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_sachuser f = new frm_sachuser();
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            frm_tguser f = new frm_tguser();
            f.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Word f = new Word();
            f.Show(this);
           
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            frm_Excel f = new frm_Excel();
            f.Show();
       
        }
    }
}
