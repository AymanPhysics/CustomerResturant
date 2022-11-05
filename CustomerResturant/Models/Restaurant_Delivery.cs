namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Restaurant_Delivery
    {
        [Key]
        public int SN { get; set; }

        public int? DeliveryID { get; set; }

        [StringLength(150)]
        public string CustName { get; set; }

        [StringLength(150)]
        public string CustPhone { get; set; }

        [StringLength(350)]
        public string CustPlace { get; set; }

        public decimal? Money { get; set; }

        public int? OrderID { get; set; }

        public int? BranchID { get; set; }
    }
}
