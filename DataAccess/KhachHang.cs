//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            this.HoaDonBans = new HashSet<HoaDonBan>();
        }
    
        public int MaKH { get; set; }
        public string TenKH { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public int SoDT { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public decimal TienNo { get; set; }
        public int LoaiKH { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}