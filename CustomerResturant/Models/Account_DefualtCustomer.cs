namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_DefualtCustomer
    {
        [Key]
        public int SN { get; set; }

        public int? ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public int? AccountID { get; set; }

        public int? BranchID { get; set; }
    }
}
