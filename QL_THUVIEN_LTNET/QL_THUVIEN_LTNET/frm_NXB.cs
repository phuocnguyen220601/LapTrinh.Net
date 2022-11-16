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
    public partial class frm_NXB : Form
    {
        public frm_NXB()
        {
            InitializeComponent();
            loaddata();
        }
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("Select * from NXB");
            if (dt != null)
            {
                dgv_nxb.DataSource = dt;
            }
            dgv_nxb.Columns[0].HeaderText = "Mã NXB ";
            dgv_nxb.Columns[0].Width = 100;
            dgv_nxb.Columns[1].Width = 180;


            dgv_nxb.Columns[1].HeaderText = "Tên NXB";
            dgv_nxb.Columns[2].HeaderText = "Địa chỉ";
            dgv_nxb.Columns[2].Width = 200;
            dgv_nxb.Columns[3].HeaderText = "Email";
            dgv_nxb.Columns[3].Width = 200;
            dgv_nxb.Columns[4].HeaderText = "SDT";


        }
        private void frm_NXB_Load(object sender, EventArgs e)
        {

        }

        private void dgv_nxb_SelectionChanged(object sender, EventArgs e)
        {
            txt_manxb.Text = dgv_nxb.CurrentRow.Cells[0].Value.ToString();
            txt_tennxb.Text = dgv_nxb.CurrentRow.Cells[1].Value.ToString();
            txt_diachi.Text = dgv_nxb.CurrentRow.Cells[2].Value.ToString();
            txt_email.Text = dgv_nxb.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_nxb.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_manxb.Text =="" || txt_tennxb.Text == ""||txt_diachi.Text == "" ||txt_email.Text == ""||txt_sdt.Text =="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin ");
            }    
            else
            {

                String sql = "Insert into NXB values (N'" + txt_manxb.Text+ "', N'" +txt_tennxb.Text+"',N'"+txt_diachi.Text+"','"+txt_email.Text+"','"+txt_sdt.Text+"')";
                if (kn.thucthidulieu(sql) == true)
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
            if (txt_manxb.Text =="" || txt_tennxb.Text == ""||txt_diachi.Text == "" ||txt_email.Text == ""||txt_sdt.Text =="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin ");
            }
            else
            {
                String sql2 = "update  NXB set TenNXB=N'" + txt_tennxb.Text + "',Diachi = N'" +txt_diachi.Text +"',Email = '"+txt_email.Text+"',SDT = '"+txt_sdt.Text+"'  where MaNXB=N'" + txt_manxb.Text + "'";
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn xóa nxb : " + txt_tennxb.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    if (kn.thucthidulieu("delete from NXB where MaNXB='" + txt_manxb.Text + "'")==true)
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
