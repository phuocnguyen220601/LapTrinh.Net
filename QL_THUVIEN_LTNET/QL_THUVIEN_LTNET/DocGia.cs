namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocGia")]
    public partial class DocGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocGia()
        {
            PhieuMuons = new HashSet<PhieuMuon>();
        }

        [Key]
        [StringLength(10)]
        public string MaDG { get; set; }

        [StringLength(40)]
        public string HoTen { get; set; }

        [StringLength(40)]
        public string Username { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(60)]
        public string Diachi { get; set; }

        public DateTime? NamSinh { get; set; }

        public long? SDT { get; set; }

        public int? Quyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuMuon> PhieuMuons { get; set; }
    }
}
