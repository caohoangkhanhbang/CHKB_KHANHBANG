﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHangCuaKhanhBang.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_WebBanHangOnlineEntities2 : DbContext
    {
        public DB_WebBanHangOnlineEntities2()
            : base("name=DB_WebBanHangOnlineEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnhDoiTra> AnhDoiTras { get; set; }
        public virtual DbSet<BinhLuan> BinhLuans { get; set; }
        public virtual DbSet<ChamSocKhachHang> ChamSocKhachHangs { get; set; }
        public virtual DbSet<ChiTietDanhMuc> ChiTietDanhMucs { get; set; }
        public virtual DbSet<ChiTietDoiTra> ChiTietDoiTras { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<ChucNang> ChucNangs { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<DiaChi> DiaChis { get; set; }
        public virtual DbSet<DoiTra> DoiTras { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<DonViVanChuyen> DonViVanChuyens { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<GioiThieuWeb> GioiThieuWebs { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<KhoiLuong> KhoiLuongs { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LichSuMuaHang> LichSuMuaHangs { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuTichDiem> PhieuTichDiems { get; set; }
        public virtual DbSet<QuanTriVien> QuanTriViens { get; set; }
        public virtual DbSet<QuangCao> QuangCaos { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<SanPham_KhoiLuong> SanPham_KhoiLuong { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TaiKhoan_DiaChi> TaiKhoan_DiaChi { get; set; }
        public virtual DbSet<ThongTinGiaoHang> ThongTinGiaoHangs { get; set; }
        public virtual DbSet<TrangThaiSanPham> TrangThaiSanPhams { get; set; }
        public virtual DbSet<UuDai> UuDais { get; set; }
        public virtual DbSet<ViDienTu> ViDienTus { get; set; }
        public virtual DbSet<YeuCauDoiTra> YeuCauDoiTras { get; set; }
    }
}