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
    public partial class frm_phieumuon : Form
    {
        public frm_phieumuon()
        {
            InitializeComponent();
            
          


        }
        public void loaddatahh()
        {
            DataTable dataTable = new DataTable();
            String sqlqh = "select * from PhieuMuon where NgayTra < GETDATE()";
            dataTable = kn.docdulieu(sqlqh);
            if(dataTable != null)
            {
                dgv_pm.DataSource = dataTable;

            }else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
            DataGridViewHeder();
        }
        public void DataGridViewHeder()
        {
            dgv_pm.Columns[0].HeaderText = "Ma PM";
            dgv_pm.Columns[0].Width = 90;
            dgv_pm.Columns[1].HeaderText = "Ma sách";
            dgv_pm.Columns[1].Width = 90;
            dgv_pm.Columns[2].HeaderText = "Ma độc giả";
            dgv_pm.Columns[2].Width = 90;
            dgv_pm.Columns[3].HeaderText = "Ma nhân viên";
            dgv_pm.Columns[3].Width = 90;
            dgv_pm.Columns[4].HeaderText = "Ngày mượn";
            dgv_pm.Columns[4].Width = 200;
            dgv_pm.Columns[5].HeaderText = "Ngày trả";
            dgv_pm.Columns[5].Width = 200;
        }
        public DateTime date1, date2;
        public TimeSpan time;
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("select * from PhieuMuon");
            lb_sl.Text = dt.Rows.Count.ToString();
            if (dt != null)
            {
                dgv_pm.DataSource = dt;

            }
            DataGridViewHeder();
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            dtpngaytra.Value = result;
            DateTime result1 = DateTime.Today;//lay ngay hien tai tang them 3 ngay
            dtp_ngaymuon.Value = result1;
        }
        public void loadcombox()
        {
           DataTable dt1 =  kn.docdulieu("select * from Sach");
            DataTable dt2 =   kn.docdulieu("select * from DocGia");
            DataTable dt3 =kn.docdulieu("select * from NhanVien");
            cb_sach.DataSource = dt1;
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "MaSach";
            cb_dg.DataSource = dt2;
            cb_dg.DisplayMember ="HoTen";
            cb_dg.ValueMember ="MaDG";
            cb_nv.DataSource = dt3;
            cb_nv.DisplayMember = "TenNv";
            cb_nv.ValueMember = "MaNv";
            


        }
        private void frm_phieumuon_Load(object sender, EventArgs e)
        {
             
            loadcombox();
            
          
        }
        public void loadsl()
        {
            DataTable dtsl = new DataTable();
            dtsl = kn.docdulieu("select * from Sach where MaSach = '"+cb_sach.SelectedValue.ToString()+"'");
            cb_sl.DataSource = dtsl;
            cb_sl.DisplayMember = "SoLuong";
        }

        private void cb_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
             loadsl();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string ngaymuon = dtp_ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngaytra = dtpngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(dtp_ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(dtpngaytra.Text);
            time = date2.Subtract(date1);
            int day;
            day = time.Days;
            if (txt_mapm.Text ==""||cb_sach.Text==""||cb_dg.Text==""||cb_nv.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin !", "Thông báo!");
            }
            else if (day <= 0)
            {
                MessageBox.Show("Ngày hẹn trả không hợp lệ !", "Thông báo");
                dtpngaytra.Focus();

            }
            else if (Convert.ToInt32(cb_sl.Text) == 0)
            {
                MessageBox.Show("Sach trong kho đã hết!Vui lòng chọn cuốn khác");
            }
            else
            {

                String sql = "update PhieuMuon set MaSach =N'"+cb_sach.SelectedValue.ToString()+"',MaDG = '" +cb_dg.SelectedValue.ToString() +"',Manv = '"+cb_nv.SelectedValue.ToString()+"',NgayMuon = N'"+ngaymuon+"',NgayTra = '"+ngaytra+"'  where MaPM = N'"+txt_mapm.Text+"'";
                if (kn.thucthidulieu(sql)==true)
                {
                    MessageBox.Show("Cập nhập thông tin thành công !", "Thông báo!");
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi !", "Thông báo!");
                }    
            }
        }

        private void dgv_pm_SelectionChanged(object sender, EventArgs e)
        {
            string s = dgv_pm.CurrentRow.Cells[2].Value.ToString();
            DataTable dt1 = kn.docdulieu("select * from DocGia where MaDG like N'"+s+"'");
            cb_dg.DataSource = dt1;
            txt_mapm.Text = dgv_pm.CurrentRow.Cells[0].Value.ToString();
            cb_sach.Text = dgv_pm.CurrentRow.Cells[1].Value.ToString();
            cb_dg.DisplayMember = "HoTen";
            cb_nv.Text = dgv_pm.CurrentRow.Cells[3].Value.ToString();
            dtp_ngaymuon.Text = dgv_pm.CurrentRow.Cells[4].Value.ToString();
            dtpngaytra.Text = dgv_pm.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_giahan_Click(object sender, EventArgs e)
        {
            string ngayhhh = dtpngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(dtp_ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(dtpngaytra.Text);
            time = date2.Subtract(date1);
            int day;
            day = time.Days;
            if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                dtpngaytra.Focus();

            }
            else if (kn.thucthidulieu("update  PhieuMuon set NgayTra=N'" + ngayhhh + "'where MaPM=N'" + txt_mapm.Text + "'") == true)
            {

                MessageBox.Show("Gia hạn thành công");
                loaddata();


            }
            else MessageBox.Show("Không thể gia hạn sách");
        }

        private void btn_trasach_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn  trả sách có mã " + cb_sach.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    kn.thucthidulieu("delete from PhieuMuon where MaPM='" + txt_mapm.Text + "'");
                    int sum;
                    sum = Convert.ToInt32(cb_sl.Text.ToString()) + 1;
                    String sql2 = "update Sach set SoLuong = '"+sum+"' where MaSach = N'"+cb_sach.SelectedValue.ToString()+"'";
                    kn.thucthidulieu(sql2);
                  
                
                    MessageBox.Show("Đã trả sach"+ cb_sach.Text +"", "Thông báo");
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

        private void lb_sl_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Admin f = new frm_Admin();
            f.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cb_tuychon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_tuychon.Text == "Tất cả phiếu mượn")
            {
                loaddata();

            }   else
            {
                loaddatahh();
            }    
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            
            string ngaymuon = dtp_ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngaytra = dtpngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(dtp_ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(dtpngaytra.Text);
            time = date2.Subtract(date1);
            int day;
            day = time.Days;
            if (txt_mapm.Text ==""||cb_sach.Text==""||cb_dg.Text==""||cb_nv.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin !", "Thông báo!");
            }
           else if(day <= 0)
            {
                MessageBox.Show("Ngày hẹn trả không hợp lệ !","Thông báo");
                dtpngaytra.Focus();

            }  
            else if(Convert.ToInt32(cb_sl.Text) <=0)
            {
                MessageBox.Show("Sach trong kho đã hết!Vui lòng chọn cuốn khác");
            }    
            else
            {
               
               
                String sql = "insert into PhieuMuon values('"+txt_mapm.Text+"','"+cb_sach.SelectedValue.ToString()+"','"+cb_dg.SelectedValue.ToString()+"','"+cb_nv.SelectedValue.ToString()+"','"+ngaymuon+"','"+ngaytra+"')";
                if(kn.thucthidulieu(sql)==true)
                {
                    
                    int sum;
                    sum = Convert.ToInt32(cb_sl.Text.ToString()) - 1;
                    String sql2 = "update Sach set SoLuong = '"+sum+"' where MaSach = N'"+cb_sach.SelectedValue.ToString()+"'";
                    if(kn.thucthidulieu(sql2)==true)
                    {
                        MessageBox.Show("Tạo phiếu mượn thành công !", "Thông báo");
                    }    
                    loaddata();
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi !","Thông báo");
                }
            }    
            
        }
    }
}
