namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ItemQuantityExpire")]
    public partial class ItemQuantityExpire
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ItemID { get; set; }

        public int? StoreID { get; set; }

        public decimal? CurrentBalance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExpireDate { get; set; }

        [StringLength(350)]
        public string Barcode { get; set; }
    }
}
