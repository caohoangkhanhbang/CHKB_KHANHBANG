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
    
    public partial class TrangThaiSanPham
    {
        public int MaTrangThai { get; set; }
        public int MaSanPham { get; set; }
        public string TrangThai { get; set; }
        public Nullable<int> SoLuotBan { get; set; }
        public string YeuThich { get; set; }
        public string SoLuong { get; set; }
        public Nullable<int> Sao { get; set; }
    
        public virtual SanPham SanPham { get; set; }
    }
}
