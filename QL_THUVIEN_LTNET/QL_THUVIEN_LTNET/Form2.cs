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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_Excel f = new frm_Excel();
            f.Show();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            frm_Login.Show();
            this.Hide();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qlsach sach = new frm_qlsach();
            sach.Show();
        }

        private void độcGỉaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_docgia sach = new frm_docgia();
            sach.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NXB sach = new frm_NXB();
            sach.Show();
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frm_NCC sach = new frm_NCC();
            sach.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_nhanvien sach = new frm_nhanvien();
            sach.Show();
        }

        private void tácGỉaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_qltacgia sach = new frm_qltacgia();
            sach.Show();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_phieumuon sach = new frm_phieumuon();
            sach.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_PhieuNhap sach = new frm_PhieuNhap();
            sach.Show();
        }

        private void sáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_timsach f = new frm_timsach();
            f.Show();
        }

        private void timKiếmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_timdocgia f = new frm_timdocgia();
            f.Show();
        }

        private void báoCáoThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_thongkesach f = new frm_thongkesach();
            f.Show();
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {

        }

        private void độcGỉaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_thongketaccgia f = new frm_thongketaccgia();
            f.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Word f = new Word();
            f.Show();
           
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
