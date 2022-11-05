namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contract_Store
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? CustID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ItemDate { get; set; }

        public decimal? Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ItemDateExpire { get; set; }

        public decimal? QuantityExpire { get; set; }
    }
}
