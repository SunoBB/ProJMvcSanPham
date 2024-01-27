using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GioiThieuSanPham.Models
{
    public partial class DBconnect : DbContext
    {
        public DBconnect()
            : base("name=DBconnect")
        {
        }

        public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangSanXuat>()
                .HasMany(e => e.SanPhams)
                .WithOptional(e => e.HangSanXuat)
                .HasForeignKey(e => e.idHang);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaBanMoi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.GiaBanCu)
                .HasPrecision(19, 4);
        }
    }
}
