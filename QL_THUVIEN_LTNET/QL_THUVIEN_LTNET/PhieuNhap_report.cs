using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_THUVIEN_LTNET
{
    internal class PhieuNhap_report
    {
        public string MaPN { get; set; }
        public string TenTg { get; set; }
        public string TenNCC { get; set; }
        public string TenNv { get; set; }
        public string TheLoai { get; set; }

        public DateTime NgayLap { get; set; }
        public int SoLuong { get; set; }
        public int TongTien { get; set; }
    }
}
