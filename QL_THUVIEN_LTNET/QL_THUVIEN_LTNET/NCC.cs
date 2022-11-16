namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCC")]
    public partial class NCC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NCC()
        {
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        [Key]
        [StringLength(10)]
        public string MaNcc { get; set; }

        [Required]
        [StringLength(120)]
        public string TenNcc { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        public long? SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
