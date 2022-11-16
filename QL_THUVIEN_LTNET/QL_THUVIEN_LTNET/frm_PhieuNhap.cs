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
    public partial class frm_PhieuNhap : Form
    {
        public frm_PhieuNhap()
        {
            InitializeComponent();
            loaddata();
            loadcombobox();
        }
        private DateTime date1;
        ketnoi kn = new ketnoi();
        public void loaddata()
        {
            DataTable dt = new DataTable();
            dt = kn.docdulieu("select * from PhieuNhap");
            lb_sl.Text = dt.Rows.Count.ToString();
            if (dt != null)
            {
                dgv_pn.DataSource = dt;

            }
            dgv_pn.Columns[0].HeaderText = "Ma PN";
            dgv_pn.Columns[0].Width = 80;
            dgv_pn.Columns[1].HeaderText = "Ma sách";
            dgv_pn.Columns[1].Width = 80;
            dgv_pn.Columns[2].HeaderText = "Ma nhà cung cấp";
            dgv_pn.Columns[2].Width = 80;
            dgv_pn.Columns[3].HeaderText = "Ma nhân viên";
            dgv_pn.Columns[3].Width = 80;
            dgv_pn.Columns[4].HeaderText = "Ngày lập phiếu";
            dgv_pn.Columns[4].Width = 180;
            dgv_pn.Columns[5].HeaderText = "Số lượng";
            dgv_pn.Columns[5].Width = 80;
            dgv_pn.Columns[6].HeaderText = "Tổng tiền";
            dgv_pn.Columns[6].Width = 200;

        
            DateTime result1 = DateTime.Today;//lay ngay hien tai tang them 3 ngay
            dtp_ngaylap.Value = result1;
        }
        public void loadcombobox()
        {
            DataTable dt1 = kn.docdulieu("select * from Sach");
            DataTable dt2 = kn.docdulieu("select * from NCC");
            DataTable dt3 = kn.docdulieu("select * from NhanVien");
            cb_sach.DataSource = dt1;
            cb_sach.DisplayMember = "TenSach";
            cb_sach.ValueMember = "MaSach";
            cb_ncc.DataSource = dt2;
            cb_ncc.DisplayMember ="TenNcc";
            cb_ncc.ValueMember ="MaNcc";
            cb_nv.DataSource = dt3;
            cb_nv.DisplayMember = "TenNv";
            cb_nv.ValueMember = "MaNv";

        }
        private void frm_PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void cb_sach_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cb_sach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtdg = new DataTable();
            dtdg = kn.docdulieu("select * from Sach where MaSach = '"+cb_sach.SelectedValue.ToString()+"'");
            if (dtdg != null)
            {
                for (int i = 0; i<dtdg.Rows.Count; i++)// cái này nó sẽ duyệt từng dòng trong table tương ứng.
                {
                    this.txt_dg.Text=dtdg.Rows[i]["Gia"].ToString();
                }
            }
            else
            {
                txt_dg.Text ="Loi";
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string ngaylap = dtp_ngaylap.Value.ToString("yyyy/MM/dd");
            
            if (txt_mapn.Text == ""|| txt_tongtien.Text == ""||cb_sach.SelectedValue.ToString()==""|| cb_ncc.SelectedValue.ToString()==""||cb_nv.SelectedValue.ToString()=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin");
            }   
            else if(nb_sl.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
            } 
            else
            {
                String sql = "insert into PhieuNhap values('"+txt_mapn.Text+"','"+cb_sach.SelectedValue.ToString()+"','"+cb_ncc.SelectedValue.ToString()+"','"+cb_nv.SelectedValue.ToString()+"','"+ngaylap+"','"+nb_sl.Value+"','"+txt_tongtien.Text+"')";
                if (kn.thucthidulieu(sql)==true)
                {
                    DataTable dtsl = new DataTable();
                    int sl;
                    Boolean check = false;
                    dtsl = kn.docdulieu("select * from Sach where MaSach = '"+cb_sach.SelectedValue.ToString()+"'");
                    if (dtsl != null)
                    {
                        for (int i = 0; i<dtsl.Rows.Count; i++)// cái này nó sẽ duyệt từng dòng trong table tương ứng.
                        {
                            sl = Convert.ToInt32(dtsl.Rows[i]["SoLuong"].ToString());
                            int sum;
                            sum = Convert.ToInt32(nb_sl.Text.ToString())  + sl;
                            String sql2 = "update Sach set SoLuong = '"+sum+"' where MaSach = N'"+cb_sach.SelectedValue.ToString()+"'";
                            if (kn.thucthidulieu(sql2)==true)
                            {
                                MessageBox.Show("Tạo phiếu mượn thành công !", "Thông báo");
                            }
                            loaddata();
                        }
                    }
                     
                   
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi !", "Thông báo");
                }
            }    
        }

        private void nb_sl_ValueChanged(object sender, EventArgs e)
        {
            double sum = 0;
            double a = 0;
            if (txt_dg.Text != "")
            {
                a = Convert.ToDouble(txt_dg.Text);
            }
            int b;
            b = Convert.ToInt32(nb_sl.Value);
            sum = a*b;
            txt_tongtien.Text= sum.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string ngaylap = dtp_ngaylap.Value.ToString("yyyy/MM/dd");

            if (txt_mapn.Text == ""|| cb_sach.Text==""|| cb_ncc.Text==""||cb_nv.Text=="")
            {
                MessageBox.Show("Vui long nhập đầy đủ thông tin");
            }
            else if (nb_sl.Value <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ");
            }
            else
            {
                String sql3 = "update PhieuNhap set MaSach =N'"+cb_sach.SelectedValue.ToString()+"',MaNcc = '" +cb_ncc.SelectedValue.ToString() +"',Manv = '"+cb_nv.SelectedValue.ToString()+"',NgayLap = N'"+ngaylap+"',SoLuong = '"+nb_sl.Value+"',TongTien = '"+txt_tongtien.Text+"'  where MaPN = N'"+txt_mapn.Text+"'";
                if (kn.thucthidulieu(sql3)==true)
                {
                    // DataTable dtsl = new DataTable();
                    //int sl;
                    //  Boolean check = false;
                    //  dtsl = kn.docdulieu("select * from Sach where MaSach = '"+cb_sach.SelectedValue.ToString()+"'");
                    //  if (dtsl != null)
                    //  {
                    //  for (int i = 0; i<dtsl.Rows.Count; i++)// cái này nó sẽ duyệt từng dòng trong table tương ứng.
                    //  {
                    //    sl = Convert.ToInt32(dtsl.Rows[i]["SoLuong"].ToString());
                    //    int sum;
                    //   sum = Convert.ToInt32(nb_sl.Text.ToString())  + sl;
                    //    String sql2 = "update Sach set SoLuong = '"+sum+"' where MaSach = N'"+cb_sach.SelectedValue.ToString()+"'";
                    //   if (kn.thucthidulieu(sql2)==true)
                    //   {
                    MessageBox.Show("Cập nhập thông tin thành công ", "Thông báo");
                    //  }
                    loaddata();
                    // }
                }
                else
                {
                    MessageBox.Show("Xảy ra lỗi ", "Thông báo");
                }
            }
           }

        private void dgv_pm_SelectionChanged(object sender, EventArgs e)
        {
            txt_mapn.Text = dgv_pn.CurrentRow.Cells[0].Value.ToString();
            cb_sach.Text = dgv_pn.CurrentRow.Cells[1].Value.ToString();
            cb_ncc.Text = dgv_pn.CurrentRow.Cells[2].Value.ToString();
            cb_nv.Text = dgv_pn.CurrentRow.Cells[3].Value.ToString();
            dtp_ngaylap.Text = dgv_pn.CurrentRow.Cells[4].Value.ToString();
            nb_sl.Text = dgv_pn.CurrentRow.Cells[5].Value.ToString();
            txt_tongtien.Text = dgv_pn.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn  xóa phieu nhap mã " + txt_mapn.Text + "", "thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    kn.thucthidulieu("delete from PhieuNhap where MaPN='" + txt_mapn.Text + "'");
                    MessageBox.Show("Đã xóa"+ txt_mapn.Text +"", "Thông báo");
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
            frm_Admin f = new frm_Admin();
            f.Show();
        }

        private void btn_giahan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_thongkephieunhap f = new frm_thongkephieunhap();
            f.Show();
        }
    }
}
