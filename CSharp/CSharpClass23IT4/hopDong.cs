//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSharpClass23IT4
{
    using System;
    using System.Collections.Generic;
    
    public partial class hopDong
    {
        public string mahd { get; set; }
        public string loaihd { get; set; }
        public Nullable<System.DateTime> ngaybbhd { get; set; }
        public Nullable<System.DateTime> ngaykthd { get; set; }
        public string maNhanVien { get; set; }
    
        public virtual nhanVien nhanVien { get; set; }
    }
}