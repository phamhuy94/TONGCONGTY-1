﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERP_DATABASEEntities : DbContext
    {
        public ERP_DATABASEEntities()
            : base("name=ERP_DATABASEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BH_BAO_GIA> BH_BAO_GIA { get; set; }
        public virtual DbSet<BH_CT_BAO_GIA> BH_CT_BAO_GIA { get; set; }
        public virtual DbSet<BH_DON_HANG_DU_KIEN> BH_DON_HANG_DU_KIEN { get; set; }
        public virtual DbSet<CATEGORy> CATEGORIES { get; set; }
        public virtual DbSet<CCTC_BANG_CHAM_CONG> CCTC_BANG_CHAM_CONG { get; set; }
        public virtual DbSet<CCTC_BANG_LUONG> CCTC_BANG_LUONG { get; set; }
        public virtual DbSet<CCTC_CONG_TY> CCTC_CONG_TY { get; set; }
        public virtual DbSet<CCTC_MO_HINH_CONG_TY> CCTC_MO_HINH_CONG_TY { get; set; }
        public virtual DbSet<CCTC_NHAN_VIEN> CCTC_NHAN_VIEN { get; set; }
        public virtual DbSet<CCTC_PHONG_BAN> CCTC_PHONG_BAN { get; set; }
        public virtual DbSet<CN_CHI_TIET_NGHIEP_VU> CN_CHI_TIET_NGHIEP_VU { get; set; }
        public virtual DbSet<CN_CHI_TIET_NHOM_NGHIEP_VU> CN_CHI_TIET_NHOM_NGHIEP_VU { get; set; }
        public virtual DbSet<CN_NGHIEP_VU> CN_NGHIEP_VU { get; set; }
        public virtual DbSet<CN_NGHIEP_VU_NHAN_VIEN> CN_NGHIEP_VU_NHAN_VIEN { get; set; }
        public virtual DbSet<CN_NHOM_NGHIEP_VU> CN_NHOM_NGHIEP_VU { get; set; }
        public virtual DbSet<DM_CHUNG_TU> DM_CHUNG_TU { get; set; }
        public virtual DbSet<DM_DINH_KHOAN_TU_DONG> DM_DINH_KHOAN_TU_DONG { get; set; }
        public virtual DbSet<DM_DOI_TUONG> DM_DOI_TUONG { get; set; }
        public virtual DbSet<DM_KHO> DM_KHO { get; set; }
        public virtual DbSet<DM_LOAI_CHUNG_TU> DM_LOAI_CHUNG_TU { get; set; }
        public virtual DbSet<DM_LOAI_DOI_TUONG> DM_LOAI_DOI_TUONG { get; set; }
        public virtual DbSet<DM_LOAI_TK_NGAN_HANG> DM_LOAI_TK_NGAN_HANG { get; set; }
        public virtual DbSet<DM_TAI_KHOAN_HACH_TOAN> DM_TAI_KHOAN_HACH_TOAN { get; set; }
        public virtual DbSet<DM_TK_NGAN_HANG_NOI_BO> DM_TK_NGAN_HANG_NOI_BO { get; set; }
        public virtual DbSet<DV> DVs { get; set; }
        public virtual DbSet<HH> HHs { get; set; }
        public virtual DbSet<HH_HANG_DUOC_QUAN_TAM> HH_HANG_DUOC_QUAN_TAM { get; set; }
        public virtual DbSet<HH_NHOM_VTHH> HH_NHOM_VTHH { get; set; }
        public virtual DbSet<HH_TON_KHO> HH_TON_KHO { get; set; }
        public virtual DbSet<HH_TONKHO_HANG> HH_TONKHO_HANG { get; set; }
        public virtual DbSet<HT_LICH_SU_DANG_NHAP> HT_LICH_SU_DANG_NHAP { get; set; }
        public virtual DbSet<HT_NGUOI_DUNG> HT_NGUOI_DUNG { get; set; }
        public virtual DbSet<KH> KHs { get; set; }
        public virtual DbSet<KH_DC_XUAT_HANG> KH_DC_XUAT_HANG { get; set; }
        public virtual DbSet<KH_LIEN_HE> KH_LIEN_HE { get; set; }
        public virtual DbSet<KH_LOAI> KH_LOAI { get; set; }
        public virtual DbSet<KH_PHAN_LOAI_KHACH> KH_PHAN_LOAI_KHACH { get; set; }
        public virtual DbSet<KH_SALES_PHU_TRACH> KH_SALES_PHU_TRACH { get; set; }
        public virtual DbSet<KH_TK_NGAN_HANG> KH_TK_NGAN_HANG { get; set; }
        public virtual DbSet<KHO_CHUYEN_KHO> KHO_CHUYEN_KHO { get; set; }
        public virtual DbSet<KHO_CT_CHUYEN_KHO> KHO_CT_CHUYEN_KHO { get; set; }
        public virtual DbSet<KHO_CT_DNXH> KHO_CT_DNXH { get; set; }
        public virtual DbSet<KHO_CT_NHAP_KHO> KHO_CT_NHAP_KHO { get; set; }
        public virtual DbSet<KHO_CT_PHIEU_GIU_HANG> KHO_CT_PHIEU_GIU_HANG { get; set; }
        public virtual DbSet<KHO_CT_XUAT_KHO> KHO_CT_XUAT_KHO { get; set; }
        public virtual DbSet<KHO_DNXH> KHO_DNXH { get; set; }
        public virtual DbSet<KHO_NHAP_KHO> KHO_NHAP_KHO { get; set; }
        public virtual DbSet<KHO_PHIEU_GIU_HANG> KHO_PHIEU_GIU_HANG { get; set; }
        public virtual DbSet<KHO_XUAT_KHO> KHO_XUAT_KHO { get; set; }
        public virtual DbSet<MAU_SO_HOA_DON> MAU_SO_HOA_DON { get; set; }
        public virtual DbSet<MENU> MENUs { get; set; }
        public virtual DbSet<MENU_USER> MENU_USER { get; set; }
        public virtual DbSet<MH_CT_MDV> MH_CT_MDV { get; set; }
        public virtual DbSet<MH_MDV> MH_MDV { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<NCC_LIEN_HE> NCC_LIEN_HE { get; set; }
        public virtual DbSet<NCC_LOAI> NCC_LOAI { get; set; }
        public virtual DbSet<NCC_LOAI_HANG_CUNG_CAP> NCC_LOAI_HANG_CUNG_CAP { get; set; }
        public virtual DbSet<NCC_PUR_PHU_TRACH> NCC_PUR_PHU_TRACH { get; set; }
        public virtual DbSet<NCC_TK_NGAN_HANG> NCC_TK_NGAN_HANG { get; set; }
        public virtual DbSet<NH_CHUYEN_TIEN_NOI_BO> NH_CHUYEN_TIEN_NOI_BO { get; set; }
        public virtual DbSet<NH_CT_NTTK> NH_CT_NTTK { get; set; }
        public virtual DbSet<NH_CT_UNC> NH_CT_UNC { get; set; }
        public virtual DbSet<NH_NTTK> NH_NTTK { get; set; }
        public virtual DbSet<NH_UNC> NH_UNC { get; set; }
        public virtual DbSet<POST_CATEGORIES> POST_CATEGORIES { get; set; }
        public virtual DbSet<POST> POSTS { get; set; }
        public virtual DbSet<QUY_CT_PHIEU_CHI> QUY_CT_PHIEU_CHI { get; set; }
        public virtual DbSet<QUY_CT_PHIEU_THU> QUY_CT_PHIEU_THU { get; set; }
        public virtual DbSet<QUY_PHIEU_CHI> QUY_PHIEU_CHI { get; set; }
        public virtual DbSet<QUY_PHIEU_THU> QUY_PHIEU_THU { get; set; }
        public virtual DbSet<XL_DANG_KY_PHE_DUYET> XL_DANG_KY_PHE_DUYET { get; set; }
        public virtual DbSet<XL_THAM_CHIEU_CHUNG_TU> XL_THAM_CHIEU_CHUNG_TU { get; set; }
    }
}
