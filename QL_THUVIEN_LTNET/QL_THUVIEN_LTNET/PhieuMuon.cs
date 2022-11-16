namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuMuon")]
    public partial class PhieuMuon
    {
        [Key]
        [StringLength(10)]
        public string MaPM { get; set; }

        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(10)]
        public string MaDG { get; set; }

        [StringLength(10)]
        public string Manv { get; set; }

        public DateTime? NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        public virtual DocGia DocGia { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
