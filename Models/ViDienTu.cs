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
    
    public partial class ViDienTu
    {
        public int MaViDienTu { get; set; }
        public int MaTaiKhoan { get; set; }
        public string SoThe { get; set; }
        public string NgayHetHan { get; set; }
        public string MaCVV { get; set; }
        public string HoTenChuThe { get; set; }
        public string DiaChiDangKy { get; set; }
        public string MaBuuChinh { get; set; }
    
        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
