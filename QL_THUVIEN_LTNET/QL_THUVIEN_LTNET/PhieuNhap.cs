namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [Key]
        [StringLength(10)]
        public string MaPN { get; set; }

        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(10)]
        public string MaNcc { get; set; }

        [StringLength(10)]
        public string Manv { get; set; }

        public DateTime? NgayLap { get; set; }

        public int? SoLuong { get; set; }

        public long? TongTien { get; set; }

        public virtual NCC NCC { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
