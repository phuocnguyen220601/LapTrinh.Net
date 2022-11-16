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
    public partial class frm_thongkesach : Form
    {
        public frm_thongkesach()
        {
            InitializeComponent();
        }

        private void frm_thongkesach_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            connect_report sach = new connect_report();
            List<Sach> listsach = sach.Saches.ToList();
            List<sach_report> listreportsach = new List<sach_report>();
            foreach (Sach s in listsach)
            {
                sach_report temp = new sach_report();
                temp.MaSach = s.MaSach;
                temp.TenSach = s.TenSach;
                temp.TenTg = s.TacGia.TenTg;
                temp.TenNXB = s.NXB.TenNXB;
                temp.TheLoai = s.TheLoai;
                temp.Gia =(int)s.Gia;
                temp.SoLuong =(int)s.SoLuong;
                temp.TinhTrang = s.TinhTrang;
                listreportsach.Add(temp);

            }
            reportViewer1.LocalReport.ReportPath ="Report_sach.rdlc";
            var source = new ReportDataSource("SachDataSet", listreportsach);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            frm_Admin f = new frm_Admin();
            f.Show();
        }
    }
}
