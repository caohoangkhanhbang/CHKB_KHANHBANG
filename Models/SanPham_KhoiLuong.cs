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
    
    public partial class SanPham_KhoiLuong
    {
        public int MaSanPham { get; set; }
        public int MaKhoiLuong { get; set; }
        public Nullable<double> Gia { get; set; }
    
        public virtual KhoiLuong KhoiLuong { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
