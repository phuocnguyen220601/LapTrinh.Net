namespace QL_THUVIEN_LTNET
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Key]
        [StringLength(10)]
        public string MaDG { get; set; }

        [StringLength(40)]
        public string Username { get; set; }

        [StringLength(10)]
        public string Pass { get; set; }

        public int? Quyen { get; set; }

        public virtual DocGia DocGia { get; set; }
    }
}
