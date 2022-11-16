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
    public partial class frm_thongketaccgia : Form
    {
        public frm_thongketaccgia()
        {
            InitializeComponent();
        }

        private void frm_thongkedocgia_Load(object sender, EventArgs e)
        {
            connect_report Tacgia = new connect_report();
            List<TacGia> Listtg = Tacgia.TacGias.ToList();
            List<TacGiaReport> tacGiaReports = new List<TacGiaReport>();
            foreach (TacGia tg in Listtg)
            {
                TacGiaReport temp = new TacGiaReport();
                temp.Matg = tg.Matg;
                temp.TenTg = tg.TenTg;
                temp.Ngaysinh = (DateTime)tg.Ngaysinh;
                temp.GioiTinh = tg.GioiTinh;
                temp.Email = tg.Email;
                temp.SDT = (int)tg.SDT;

                tacGiaReports.Add(temp);

            }
            reportViewer1.LocalReport.ReportPath ="taccgia_report.rdlc";
            var source = new ReportDataSource("TacgiaDataSet", tacGiaReports);
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
