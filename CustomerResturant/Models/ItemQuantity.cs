namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemQuantity")]
    public partial class ItemQuantity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemQuantityID { get; set; }

        public int? ItemID { get; set; }

        public int? StoreID { get; set; }

        public decimal? OpeningBalance { get; set; }

        public decimal? CurrentBalance { get; set; }

        public decimal? BeginningInventory { get; set; }

        public decimal? BeginningInventoryPrice { get; set; }

        public virtual Account_Stores Account_Stores { get; set; }
    }
}
