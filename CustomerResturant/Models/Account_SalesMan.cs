namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_SalesMan
    {
        [Key]
        public int SN { get; set; }

        public int? ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        public int? BranchID { get; set; }

        public decimal? profit { get; set; }

        public bool? ISProfitOrder { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        public int? PlaceID { get; set; }

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
    }
}
