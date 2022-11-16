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
    public partial class frm_docgia : Form
    {
        public frm_docgia()
        {
            InitializeComponent();
            loaddata();

        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("SELECT * FROM DocGia");
            if(dt != null)
            {
                dgv_dg.DataSource = dt;
            }
            dgv_dg.Columns[0].HeaderText = "Ma DG";
            dgv_dg.Columns[1].HeaderText = "Ten DG";
            dgv_dg.Columns[2].HeaderText = "Username";
            dgv_dg.Columns[3].HeaderText = "Password";
            dgv_dg.Columns[4].HeaderText = "Gioi tính";
            dgv_dg.Columns[5].HeaderText = "Địa chỉ";
            dgv_dg.Columns[6].HeaderText = "Ngày sinh";
            dgv_dg.Columns[7].HeaderText ="SDT";
            dgv_dg.Columns[8].HeaderText ="Quyền";


        }

        private void frm_docgia_Load(object sender, EventArgs e)
        {

        }

        private void dgv_dg_SelectionChanged(object sender, EventArgs e)
        {
            txt_madg.Text = dgv_dg.CurrentRow.Cells[0].Value.ToString();
            txt_tendg.Text = dgv_dg.CurrentRow.Cells[1].Value.ToString();
            txt_username.Text = dgv_dg.CurrentRow.Cells[2].Value.ToString();
            txt_pass.Text = dgv_dg.CurrentRow.Cells[3].Value.ToString();
            cb_gioitinh.Text = dgv_dg.CurrentRow.Cells[4].Value.ToString();
            txt_diachi.Text = dgv_dg.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinh.Text = dgv_dg.CurrentRow.Cells[6].Value.ToString();
            txt_sdt.Text = dgv_dg.CurrentRow.Cells[7].Value.ToString();
            cb_quyen.Text = dgv_dg.CurrentRow.Cells[8].Value.ToString();
        }

        private void cb_quyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_madg.Text ==""||txt_username.Text ==""||txt_pass.Text ==""||txt_diachi.Text==""||txt_sdt.Text==""||txt_tendg.Text==""||cb_gioitinh.Text==""||cb_quyen.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin đăng nhập","Thông báo");
            }
            else
            {
                String sql = "Insert into DocGia values ('"+txt_madg.Text+"',N'"+txt_tendg.Text+"','"+txt_username.Text+"',N'"+txt_pass.Text+"','"+cb_gioitinh.Text+"',N'"+txt_diachi.Text+"',N'"+dtp_ngaysinh.Text+"',N'"+txt_sdt.Text+"',N'"+cb_quyen.Text+"')";
                if (kn.thucthidulieu(sql)==true)
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
            if (txt_madg.Text ==""||txt_username.Text ==""||txt_pass.Text ==""||txt_diachi.Text==""||txt_sdt.Text==""||txt_tendg.Text==""||cb_gioitinh.Text==""||cb_quyen.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin đăng nhập", "Thông báo");
            }
            else
            {
                String sql2 = "update  DocGia set HoTen=N'" + txt_tendg.Text + "',Username=N'"+txt_username.Text+"',Pass ='" +txt_pass.Text +"',GioiTinh =N'"+cb_gioitinh.Text+"',DiaChi =N'"+txt_diachi.Text+"',NamSinh =N'"+dtp_ngaysinh.Text+"',SDT = '"+txt_sdt.Text+"',Quyen =N'"+cb_quyen.Text+"'  where MaDG=N'" + txt_madg.Text + "'";
                if (kn.thucthidulieu(sql2)==true)
                {
                    MessageBox.Show("Cập nhập thành công !", "Thông báo");
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
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả : " + txt_tendg.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from DocGia where MaDG='" + txt_madg.Text + "'")==true)
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
