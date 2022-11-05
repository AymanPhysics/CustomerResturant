namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_PriceOfferDetails
    {
        [Key]
        public int SN { get; set; }

        public int? Purchese_ID { get; set; }

        public int? ItemID { get; set; }

        public int? BranchID { get; set; }

        public int? StoreID { get; set; }

        public int? ItemUnitID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? LastCost { get; set; }

        public decimal? SmallUnitPrice { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? VAT { get; set; }

        public decimal? NetUnitPrice { get; set; }

        public decimal? NetTotalPrice { get; set; }

        public decimal? VAT_Discount { get; set; }

        [StringLength(150)]
        public string ItemUnitType { get; set; }
    }
}
