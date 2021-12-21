namespace QuanLyGiaoVien.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTCONGVIEC")]
    public partial class CTCONGVIEC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCV { get; set; }

        [StringLength(500)]
        public string NoiDungCV { get; set; }

        [StringLength(500)]
        public string GhiChu { get; set; }

        public int? GioChuan { get; set; }

        public virtual CONGVIEC CONGVIEC { get; set; }

        public virtual GIAOVIEN GIAOVIEN { get; set; }
    }
}
