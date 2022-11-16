using Microsoft.Reporting.WinForms;
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
    public partial class frm_thongkephieunhap : Form
    {
        public frm_thongkephieunhap()
        {
            InitializeComponent();
        }

        private void frm_thongkephieunhap_Load(object sender, EventArgs e)
        {
            connect_report phieunhap = new connect_report();
            List<PhieuNhap> listPN = phieunhap.PhieuNhaps.ToList();
            List<PhieuNhap_report> listPNreport = new List<PhieuNhap_report>();
            foreach (PhieuNhap s in listPN)
            {
                PhieuNhap_report temp = new PhieuNhap_report();
                temp.MaPN = s.MaPN;
                temp.TenTg = s.Sach.TenSach;
                temp.TenNCC = s.NCC.TenNcc;
                temp.TenNv = s.NhanVien.TenNv;
                temp.TheLoai = s.Sach.TheLoai;
                temp.SoLuong =(int)s.SoLuong;
                temp.TongTien =(int)s.TongTien;
                temp.NgayLap = (DateTime)s.NgayLap;
                listPNreport.Add(temp);

            }
            reportViewer1.LocalReport.ReportPath ="Report_phieunhap.rdlc";
            var source = new ReportDataSource("PNDataSet", listPNreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void frm_thongkephieunhap_Leave(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Admin f = new frm_Admin();
            f.Show();
        }
    }
}
