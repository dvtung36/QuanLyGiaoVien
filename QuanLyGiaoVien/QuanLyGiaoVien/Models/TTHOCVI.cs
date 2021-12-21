namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TTHOCVI")]
    public partial class TTHOCVI
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBD { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }

        public virtual HOCVI HOCVI { get; set; }
    }
}
