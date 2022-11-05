namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblSetting")]
    public partial class TblSetting
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(150)]
        public string CompanyNameAr { get; set; }

        [StringLength(150)]
        public string CompanyNameEn { get; set; }

        [StringLength(150)]
        public string CompanyNamePrintFatora { get; set; }

        [StringLength(100)]
        public string VatNum { get; set; }

        [StringLength(100)]
        public string CommercialRegister { get; set; }

        [StringLength(150)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(150)]
        public string Web { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        public int? Currency_Dividing { get; set; }

        public bool? IsVat { get; set; }

        public int? Tafqit_ID { get; set; }

        public int? StoreID { get; set; }

        public int? StoreIDWaiying { get; set; }

        public bool? IsPrintSecondCasheir { get; set; }

        public bool? IsPrintSecondFatoraCasheir { get; set; }

        public bool? IsTakeDateApp { get; set; }

        public int? GroupSize { get; set; }

        [StringLength(150)]
        public string GroupColor { get; set; }

        [StringLength(150)]
        public string GroupFontColor { get; set; }

        public int? ItemSize { get; set; }

        [StringLength(150)]
        public string ItemColor { get; set; }

        [StringLength(150)]
        public string ItemFontColor { get; set; }

        public bool? IsItemNameAR { get; set; }

        public bool? IsItemNameEN { get; set; }

        public bool? IsItemShowPrice { get; set; }

        [StringLength(150)]
        public string ItemNameAR { get; set; }

        [StringLength(150)]
        public string ItemNameEN { get; set; }

        [StringLength(150)]
        public string ItemShowPrice { get; set; }

        public bool? IsRestaurant { get; set; }

        public string DateDemo { get; set; }

        public string ISDemo { get; set; }

        public string DateDemoStart { get; set; }

        public string PathBackup { get; set; }

        public bool? IsBackupwhenClose { get; set; }

        public bool? IsItemExpire { get; set; }

        public bool? IsTobacc { get; set; }

        public bool? IsImage { get; set; }

        [StringLength(150)]
        public string SecondPrintDefualt { get; set; }

        public bool? IsShowRoomInFormRestaurant { get; set; }

        public bool? DiscountDecimal { get; set; }

        public bool? NoDiscountDecimal { get; set; }

        public bool? DiscountDecimalForCustomer { get; set; }

        public bool? IsPrintCashier { get; set; }

        public bool? IsPrintOrder { get; set; }

        public bool? IsPrintReturnOrder { get; set; }
    }
}
