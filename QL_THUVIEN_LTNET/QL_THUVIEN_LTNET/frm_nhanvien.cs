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
    public partial class frm_nhanvien : Form
    {
        public frm_nhanvien()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("select * from NhanVien");
            if(dt != null)
            {
                dgv_nv.DataSource = dt;
            }
            dgv_nv.Columns[0].HeaderText = "Mã nhân viên";
            dgv_nv.Columns[0].Width = 65;
            dgv_nv.Columns[1].HeaderText = "Tên nhân viên";
            dgv_nv.Columns[1].Width = 180;
            dgv_nv.Columns[2].HeaderText = "Gioi tính";
            dgv_nv.Columns[2].Width = 65;
            dgv_nv.Columns[3].HeaderText = "Địa chỉ";
            dgv_nv.Columns[3].Width = 200;
            dgv_nv.Columns[4].HeaderText ="Ngày sinh";
            dgv_nv.Columns[4].Width = 130;
            dgv_nv.Columns[5].HeaderText = "SDT";
            dgv_nv.Columns[5].Width = 130;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {

        }

        private void dgv_nv_SelectionChanged(object sender, EventArgs e)
        {
            txt_manv.Text =  dgv_nv.CurrentRow.Cells[0].Value.ToString();
            txt_tennv.Text =  dgv_nv.CurrentRow.Cells[1].Value.ToString();
            cb_gioitinh.Text =  dgv_nv.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dgv_nv.CurrentRow.Cells[4].Value.ToString();
            txt_diachi.Text =  dgv_nv.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text =  dgv_nv.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_manv.Text == ""||txt_tennv.Text == ""||cb_gioitinh.Text ==""||txt_diachi.Text ==""||txt_sdt.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin nhân viên!","Thông báo");
            }    
            else
            {
                String sql = "Insert into NhanVien values ('"+txt_manv.Text+"',N'"+txt_tennv.Text+"','"+cb_gioitinh.Text+"',N'"+txt_diachi.Text+"','"+dateTimePicker1.Text+"','"+txt_sdt.Text+"')";
                 if(kn.thucthidulieu(sql)==true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                    loaddata();
                }    
                 else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo");
                }    
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == ""||txt_tennv.Text == ""||cb_gioitinh.Text ==""||txt_diachi.Text ==""||txt_sdt.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin nhân viên!", "Thông báo");
            }
            else
            {
                String sql2 = "update  NhanVien set TenNv=N'" + txt_tennv.Text + "',GioiTinh =N'"+cb_gioitinh.Text+"',Namsinh ='" +dateTimePicker1.Text +"',DiaChi =N'"+txt_diachi.Text+"',SDT = '"+txt_sdt.Text+"'  where Manv=N'" + txt_manv.Text + "'";
                if (kn.thucthidulieu(sql2)==true)
                {
                    MessageBox.Show("Cập nhập  thành công !", "Thông báo");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo");
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa nxb : " + txt_tennv.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from NhanVien where Manv='" + txt_manv.Text + "'")==true)
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
