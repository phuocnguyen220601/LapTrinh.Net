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
    public partial class frm_NCC : Form
    {
        public frm_NCC()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("Select * from NCC");
            if(dt != null)
            {
                dgv_ncc.DataSource = dt;
            }
            dgv_ncc.Columns[0].HeaderText = "Mã NCC";
            dgv_ncc.Columns[0].Width = 80;
            dgv_ncc.Columns[1].HeaderText = "Tên NCC";
            dgv_ncc.Columns[1].Width = 180;
            dgv_ncc.Columns[2].HeaderText = "Địa chỉ";
            dgv_ncc.Columns[2].Width = 180;
            dgv_ncc.Columns[3].HeaderText = "Email";
            dgv_ncc.Columns[3].Width = 180;
            dgv_ncc.Columns[4].HeaderText = "SDT";
            dgv_ncc.Columns[4].Width = 150;

        }
        private void frm_NCC_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_mancc.Text ==""||txt_tenncc.Text==""||txt_diachi.Text ==""||txt_email.Text ==""||txt_sdt.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Thông Báo");
            }    
            else
            {
                String sql = "Insert into NCC values( N'"+txt_mancc.Text+"',N'"+txt_tenncc.Text+"',N'"+txt_diachi.Text+"','"+txt_email.Text+"','"+txt_sdt.Text+"')";
                if(kn.thucthidulieu(sql)==true)
                {
                    MessageBox.Show("Thêm thành công !", "Thông báo");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi !","Thông báo");
                }
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_mancc.Text =="" || txt_tenncc.Text == ""||txt_diachi.Text == "" ||txt_email.Text == ""||txt_sdt.Text =="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin ");
            }
            else
            {
                String sql2 = "update  NCC set TenNcc=N'" + txt_tenncc.Text + "',Diachi = N'" +txt_diachi.Text +"',Email = '"+txt_email.Text+"',SDT = '"+txt_sdt.Text+"'  where MaNCC=N'" + txt_mancc.Text + "'";
                if (kn.thucthidulieu(sql2)==true)
                {
                    MessageBox.Show("Cap nhap thong tin thanh cong!");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Loi cap nhap !");
                }
            }
        }

        private void dgv_ncc_SelectionChanged(object sender, EventArgs e)
        {
            txt_mancc.Text = dgv_ncc.CurrentRow.Cells[0].Value.ToString();
            txt_tenncc.Text = dgv_ncc.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = dgv_ncc.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_ncc.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_ncc.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa nxb : " + txt_tenncc.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from NCC where MaNCC='" + txt_mancc.Text + "'")==true)
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
