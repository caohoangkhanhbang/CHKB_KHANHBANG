//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GioHang
    {
        public int MaTaiKhoan { get; set; }
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<double> TongThanhToan { get; set; }
        public Nullable<double> ThanhTien { get; set; }
        public Nullable<double> DonGia { get; set; }
        public string AnhSanPham { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
