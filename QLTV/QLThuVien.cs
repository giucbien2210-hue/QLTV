using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLTV
{
    // Lớp quản lý thư viện (DbContext sẽ tạo riêng)
    internal class QLThuVien
    {
    }

    public class Sach
    {
        [Key]
        public int MaSach { get; set; }

        [Required]
        public string TenSach { get; set; }

        // Khóa ngoại
        public int MaTacGia { get; set; }
        [ForeignKey("MaTacGia")]
        public TacGia TacGia { get; set; }

        public int MaNXB { get; set; }
        [ForeignKey("MaNXB")]
        public NhaXuatBan NhaXuatBan { get; set; }

        public int MaLoai { get; set; }
        [ForeignKey("MaLoai")]
        public LoaiSach LoaiSach { get; set; }

        public int SoTrang { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
    }

    public class LoaiSach
    {
        [Key]
        public int MaLoai { get; set; }

        [Required]
        public string TenLoaiSach { get; set; }

        public string GhiChu { get; set; }

        // Quan hệ 1-nhiều (Một loại có nhiều sách)
        public ICollection<Sach> Saches { get; set; }
    }

    public class TacGia
    {
        [Key]
        public int MaTacGia { get; set; }

        [Required]
        public string TenTacGia { get; set; }

        public string GhiChu { get; set; }

        public ICollection<Sach> Saches { get; set; }
    }

    public class NhaXuatBan
    {
        [Key]
        public int MaNXB { get; set; }

        [Required]
        public string TenNXB { get; set; }

        public string GhiChu { get; set; }

        public ICollection<Sach> Saches { get; set; }
    }

    public class SinhVien
    {
        [Key]
        public int MaSV { get; set; }

        [Required]
        public string TenSV { get; set; }

        public string NganhHoc { get; set; }
        public string KhoaHoc { get; set; }
        public string SoDienThoai { get; set; }

        public ICollection<MuonTra> MuonTras { get; set; }
    }

    public class MuonTra
    {
        [Key]
        public int MaPM { get; set; } // mã phiếu mượn

        [Required]
        public int MaSV { get; set; }
        [ForeignKey("MaSV")]
        public SinhVien SinhVien { get; set; }

        public int MaSach { get; set; }
        [ForeignKey("MaSach")]
        public Sach Sach { get; set; }

        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }
        public string GhiChu { get; set; }
    }
}
