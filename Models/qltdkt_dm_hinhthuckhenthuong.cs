//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTDKT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class qltdkt_dm_hinhthuckhenthuong
    {
        public int id { get; set; }
        public string tenHinhThucKhenThuong { get; set; }
        public string moTa { get; set; }
        public Nullable<System.DateTime> ngayTao { get; set; }
        public Nullable<bool> daXoa { get; set; }
        public Nullable<byte> loaiKhenThuong { get; set; }
        public Nullable<int> chuKy { get; set; }
        public string maThanhTich { get; set; }
        public Nullable<int> capThanhTich { get; set; }
        public string chuKyKT { get; set; }
        public string capKyThanhTich { get; set; }
        public Nullable<int> bophan { get; set; }
    }
}
