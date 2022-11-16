namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NXB")]
    public partial class NXB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NXB()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        [StringLength(10)]
        public string MaNXB { get; set; }

        [StringLength(40)]
        public string TenNXB { get; set; }

        [StringLength(100)]
        public string Diachi { get; set; }

        [StringLength(60)]
        public string Email { get; set; }

        public long? SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
