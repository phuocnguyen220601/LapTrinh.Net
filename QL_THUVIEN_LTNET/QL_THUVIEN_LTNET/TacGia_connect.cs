using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QL_THUVIEN_LTNET
{
    public partial class TacGia_connect : DbContext
    {
        public TacGia_connect()
            : base("name=TacGia_connect")
        {
        }

        public virtual DbSet<TacGia> TacGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
