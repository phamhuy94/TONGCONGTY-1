//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP.Web.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHO_NHAP_KHO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHO_NHAP_KHO()
        {
            this.KHO_CT_NHAP_KHO = new HashSet<KHO_CT_NHAP_KHO>();
        }
    
        public string SO_CHUNG_TU { get; set; }
        public System.DateTime NGAY_CHUNG_TU { get; set; }
        public System.DateTime NGAY_HACH_TOAN { get; set; }
        public string LOAI_NHAP_KHO { get; set; }
        public string MA_DOI_TUONG { get; set; }
        public string NGUOI_GIAO_HANG { get; set; }
        public string DIEN_GIAI { get; set; }
        public string NHAN_VIEN_MUA_HANG { get; set; }
        public decimal TONG_TIEN { get; set; }
        public string TRUC_THUOC { get; set; }
        public string NGUOI_LAP_PHIEU { get; set; }
    
        public virtual CCTC_CONG_TY CCTC_CONG_TY { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN { get; set; }
        public virtual CCTC_NHAN_VIEN CCTC_NHAN_VIEN1 { get; set; }
        public virtual DM_LOAI_DOI_TUONG DM_LOAI_DOI_TUONG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO { get; set; }
    }
}