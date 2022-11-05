namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item_ItemComponent
    {
        [Key]
        public int SN { get; set; }

        public int? ItemID_Master { get; set; }

        public int? ItemID_Complant { get; set; }

        public decimal? Amount { get; set; }

        public int? User_Add { get; set; }

        [StringLength(100)]
        public string User_MacAddress { get; set; }

        public int? StoreID { get; set; }

        public int? ItemUnitID { get; set; }

        public decimal? SmallUnitPrice { get; set; }

        public decimal? TotalPrice { get; set; }

        [StringLength(150)]
        public string ItemUnitType { get; set; }
    }
}
