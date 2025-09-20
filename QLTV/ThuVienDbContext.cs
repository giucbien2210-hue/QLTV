using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace QLTV
{
    public class ThuVienDbContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<LoaiSach> LoaiSach { get; set; }
        public DbSet<TacGia> TacGia { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBan { get; set; }
        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<MuonTra> MuonTra { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-NBE6SMB8;Database=QuanLyTV;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
