namespace GioiThieuSanPham.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string TenSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaBanMoi { get; set; }

        [Column(TypeName = "money")]
        public decimal? GiaBanCu { get; set; }

        [StringLength(250)]
        public string TomTat { get; set; }

        public string BaiViet { get; set; }

        public int? idHang { get; set; }

        public virtual HangSanXuat HangSanXuat { get; set; }
    }
}
