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
    
    public partial class ChiTietDoiTra
    {
        public int MaDoiTra { get; set; }
        public int MaSanPham { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string LyDo { get; set; }
        public string TinhTrang { get; set; }
    
        public virtual DoiTra DoiTra { get; set; }
    }
}