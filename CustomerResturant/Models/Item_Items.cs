namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item_Items
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemId { get; set; }

        [StringLength(150)]
        public string Item_code { get; set; }

        [StringLength(150)]
        public string item_Name { get; set; }

        [StringLength(150)]
        public string item_Name_English { get; set; }

        public string Note { get; set; }

        public int? item_Type { get; set; }

        public int? Category_ID { get; set; }

        public int? Class_ID { get; set; }

        public int? CompanyID { get; set; }

        public int? GuaranteeID { get; set; }

        public int? CountryID { get; set; }

        public int? UnitSmall { get; set; }

        public int? UnitMedium { get; set; }

        public int? UnitLarge { get; set; }

        [StringLength(70)]
        public string SmallBarCode1 { get; set; }

        [StringLength(70)]
        public string SmallBarCode2 { get; set; }

        [StringLength(70)]
        public string SmallBarCode3 { get; set; }

        [StringLength(150)]
        public string LocationSmall { get; set; }

        public decimal? SellPriceSmall { get; set; }

        public decimal? SellPriceSmall2 { get; set; }

        public decimal? SellPriceSmall3 { get; set; }

        public decimal? LastCost { get; set; }

        public decimal? Average_cost { get; set; }

        public decimal? PriceExportunit1 { get; set; }

        public decimal? PriceMowazaunit1 { get; set; }

        public decimal? SmallUnitQuantity { get; set; }

        [StringLength(70)]
        public string MediumBarCode1 { get; set; }

        [StringLength(70)]
        public string MediumBarCode2 { get; set; }

        [StringLength(70)]
        public string MediumBarCode3 { get; set; }

        [StringLength(150)]
        public string LocationMedium { get; set; }

        public decimal? ConvertMediumUnit { get; set; }

        public decimal? SellPriceMedium { get; set; }

        public decimal? SellPriceMedium2 { get; set; }

        public decimal? SellPriceMedium3 { get; set; }

        public decimal? LastCost2 { get; set; }

        public decimal? PriceExportunit2 { get; set; }

        public decimal? PriceMowazaunit2 { get; set; }

        public decimal? SmallUnitQuantity2 { get; set; }

        [StringLength(70)]
        public string BigBarCode1 { get; set; }

        [StringLength(70)]
        public string BigBarCode2 { get; set; }

        [StringLength(70)]
        public string BigBarCode3 { get; set; }

        [StringLength(150)]
        public string LocationLarge { get; set; }

        public decimal? ConvertBigUnit { get; set; }

        public decimal? SellpriceLarge { get; set; }

        public decimal? SellpriceLarge2 { get; set; }

        public decimal? SellpriceLarge3 { get; set; }

        public decimal? LastCost3 { get; set; }

        public decimal? PriceExportunit3 { get; set; }

        public decimal? PriceMowazaunit3 { get; set; }

        public decimal? SmallUnitQuantity3 { get; set; }

        public bool? IsOffer { get; set; }

        public decimal? NumOffer { get; set; }

        public decimal? PriceOffer { get; set; }

        public bool? Is_Tax { get; set; }

        public decimal? Tax_Value { get; set; }

        public bool? Is_Item_mizan { get; set; }

        public string Image { get; set; }

        public int? UserID_Add { get; set; }

        public int? UserBranch_Add { get; set; }

        [StringLength(100)]
        public string UserMacAddress_Add { get; set; }

        public DateTime? UserDate_Add { get; set; }

        public int? UserID_Update { get; set; }

        public int? UserBranch_Update { get; set; }

        [StringLength(100)]
        public string UserMacAddress_Update { get; set; }

        public DateTime? UserDate_Update { get; set; }

        public virtual Item_Unit Item_Unit { get; set; }

        public virtual Item_Unit Item_Unit1 { get; set; }

        public virtual Item_Unit Item_Unit2 { get; set; }
    }
}
