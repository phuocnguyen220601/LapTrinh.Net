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
    public partial class frm_qlsach : Form
    {
        public frm_qlsach()
        {
            InitializeComponent();
            loaddata();
            loadcombo();
        }
        ketnoi kn = new ketnoi();
        private void loaddata()
        {
            DataTable dt = kn.docdulieu("select * from Sach");

            if (dt != null)
            {
                dgv_sach.DataSource = dt;
            }
            dgv_sach.Columns[0].HeaderText = "Mã sách ";
            dgv_sach.Columns[0].Width = 80;
            dgv_sach.Columns[1].Width = 150;


            dgv_sach.Columns[1].HeaderText = "Tên sách";
            dgv_sach.Columns[2].HeaderText = "Mã tác giả";
            dgv_sach.Columns[2].Width = 80;
            dgv_sach.Columns[3].HeaderText = "Mã nhà xuất bản";
            dgv_sach.Columns[3].Width = 80;
            dgv_sach.Columns[4].HeaderText = "Thể loại";
            dgv_sach.Columns[6].HeaderText = "Gía";
            dgv_sach.Columns[5].HeaderText = "Số lượng";
            dgv_sach.Columns[7].HeaderText = "Tình trạng";
        }
        private void loadcombo()
        {
            DataTable dt = kn.docdulieu("select * from NXB");
            DataTable dt1 = kn.docdulieu("select * from TacGia");
        


            cb_nxb.DataSource = dt;
            cb_nxb.DisplayMember = "TenNXB";
            cb_nxb.ValueMember = "MaNXB";
            //comnhaxb.DisplayMember = "tennxb";
            //comnhaxb.ValueMember = "manxb";
            cb_tg.DataSource = dt1;
            cb_tg.DisplayMember = "TenTg";
            cb_tg.ValueMember = "Matg";
          

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frm_qlsach_Load(object sender, EventArgs e)
        {

        }

        private void dgv_sach_SelectionChanged(object sender, EventArgs e)
        {
            txt_masach.Text = dgv_sach.CurrentRow.Cells[0].Value.ToString();
            txt_tensach.Text = dgv_sach.CurrentRow.Cells[1].Value.ToString();
            cb_tg.Text = dgv_sach.CurrentRow.Cells[2].Value.ToString();
            cb_nxb.Text = dgv_sach.CurrentRow.Cells[3].Value.ToString();
            txt_theloai.Text = dgv_sach.CurrentRow.Cells[4].Value.ToString();
            txt_dg.Text = dgv_sach.CurrentRow.Cells[6].Value.ToString();
            nb_sl.Text = dgv_sach.CurrentRow.Cells[5].Value.ToString();
            txt_tinhtrang.Text = dgv_sach.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_masach.Text == ""|| txt_tensach.Text == "" ||txt_theloai.Text == ""||txt_tinhtrang.Text ==""||txt_dg.Text ==""||cb_nxb.Text ==""||cb_tg.Text==""||nb_sl.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                String sql = "Insert into Sach values ('" +txt_masach.Text+"',N'"+txt_tensach.Text+"','"+cb_tg.SelectedValue.ToString()+"','" + cb_nxb.SelectedValue.ToString()+"',N'" +txt_theloai.Text+"','"+nb_sl.Value+"','"+txt_dg.Text+"',N'"+txt_tinhtrang.Text+"')";
                if(kn.thucthidulieu(sql) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    loaddata();
                }    
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra !");
                }    
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_masach.Text == ""|| txt_tensach.Text == "" ||txt_theloai.Text == ""||txt_tinhtrang.Text ==""||txt_dg.Text ==""||cb_nxb.Text ==""||cb_tg.Text==""||nb_sl.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !");
            }
            else
            {
                String sql2 = "update Sach set TenSach =N'"+txt_tensach.Text+"',Matg = '" +cb_tg.SelectedValue.ToString() +"',MaNXB = '"+cb_nxb.SelectedValue.ToString()+"',TheLoai = N'"+txt_theloai.Text+"',SoLuong = '"+nb_sl.Value+"',Gia = '"+txt_dg.Text+"',TinhTrang =N'"+txt_tinhtrang.Text+"' where MaSach = N'"+txt_masach.Text+"'";
                if (kn.thucthidulieu(sql2) == true)
                {
                    MessageBox.Show("Cập nhập thông tin  thành công!");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra !");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa sach " + txt_tensach.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from Sach where MaSach='" + txt_masach.Text + "'")==true)
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                    else MessageBox.Show("Không thể xóa", "Thông báo");
                    loaddata();


                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    throw;
                }

            }
            else loaddata();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frm_Admin();
            f.Show();
        }
    }
}
