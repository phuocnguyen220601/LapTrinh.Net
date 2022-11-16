namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        [StringLength(10)]
        public string MaSach { get; set; }

        [StringLength(100)]
        public string TenSach { get; set; }

        [StringLength(10)]
        public string Matg { get; set; }

        [StringLength(10)]
        public string MaNXB { get; set; }

        [StringLength(40)]
        public string TheLoai { get; set; }

        public int? SoLuong { get; set; }

        public int? Gia { get; set; }

        [StringLength(20)]
        public string TinhTrang { get; set; }

        public virtual NXB NXB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }

        public virtual TacGia TacGia { get; set; }
    }
}
