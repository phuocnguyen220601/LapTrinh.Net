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
    public partial class frm_qltacgia : Form
    {
        public frm_qltacgia()
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
                dgv_tg.DataSource = dt;
            }
            dgv_tg.Columns[0].HeaderText = "Mã tác giả ";
            dgv_tg.Columns[0].Width = 100;
            dgv_tg.Columns[1].Width = 180;


            dgv_tg.Columns[1].HeaderText = "Tên tác giả";
            dgv_tg.Columns[2].HeaderText = "Ngày sinh";
            dgv_tg.Columns[2].Width = 100;
            dgv_tg.Columns[3].HeaderText = "Gioi tính";
            dgv_tg.Columns[3].Width = 100;
            dgv_tg.Columns[4].HeaderText = "Email";
            dgv_tg.Columns[4].Width = 180;
            dgv_tg.Columns[5].HeaderText = "Số điện thoại";
         
        }
        private void frm_qltacgia_Load(object sender, EventArgs e)
        {

        }

        private void dgv_tg_SelectionChanged(object sender, EventArgs e)
        {
            txt_matg.Text = dgv_tg.CurrentRow.Cells[0].Value.ToString();
            txt_tentg.Text = dgv_tg.CurrentRow.Cells[1].Value.ToString();
            dtp_ngaysinh.Text = dgv_tg.CurrentRow.Cells[2].Value.ToString();
            cb_gioitinh.Text = dgv_tg.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dgv_tg.CurrentRow.Cells[4].Value.ToString();
            txt_sdt.Text = dgv_tg.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(txt_matg.Text == ""||txt_tentg.Text ==""||txt_sdt.Text == ""||txt_email.Text ==""||cb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui long nhap đầy đủ thông tin!");
            }    
            else
            {
                String sql = "Insert into TacGia values (N'" + txt_matg.Text+ "', N'" +txt_tentg.Text+"','"+dtp_ngaysinh.Text+"','"+cb_gioitinh.Text+"','"+txt_email.Text+"','"+txt_sdt.Text+"')";
                if(kn.thucthidulieu(sql) == true)
                {
                    MessageBox.Show("Thêm thành công!");
                    loaddata();
                }    
                else
                {
                    MessageBox.Show("Lỗi !");
                }    
            }    
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_matg.Text == ""||txt_tentg.Text ==""||txt_sdt.Text == ""||txt_email.Text ==""||cb_gioitinh.Text == "")
            {
                MessageBox.Show("Vui long nhap đầy đủ thông tin!");
            }    
            else
            {
                String sql2 = "update  tacgia set TenTg=N'" + txt_tentg.Text + "',Ngaysinh = '" +dtp_ngaysinh.Text +"',GioiTinh = '"+cb_gioitinh.Text+"',Email = '"+txt_email.Text+"',SDT = '"+txt_sdt.Text+"'  where Matg=N'" + txt_matg.Text + "'";
                if(kn.thucthidulieu(sql2)==true)
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa tac gia " + txt_tentg.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from TacGia where Matg='" + txt_matg.Text + "'")==true)
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
