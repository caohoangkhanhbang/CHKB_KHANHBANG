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
    
    public partial class NhanVien
    {
        public int MaNhanVien { get; set; }
        public Nullable<int> MaTaiKhoan { get; set; }
        public Nullable<int> MaLoaiNhanVien { get; set; }
    
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
