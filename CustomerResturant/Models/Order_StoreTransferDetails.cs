namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_StoreTransferDetails
    {
        [Key]
        public int SN { get; set; }

        public int? Trans_ID { get; set; }

        public int? BranchID { get; set; }

        public int? ItemID { get; set; }

        public int? ItemUnitID { get; set; }

        public decimal? Quantity { get; set; }

        public decimal? SmallUnitPrice { get; set; }

        public decimal? UnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        [StringLength(150)]
        public string ItemUnitType { get; set; }
    }
}
