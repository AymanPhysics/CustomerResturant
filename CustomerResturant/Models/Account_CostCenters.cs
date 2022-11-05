namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_CostCenters
    {
        [Key]
        public int SN { get; set; }

        public int? CostCentersID { get; set; }

        public int? CostCentersNo { get; set; }

        [StringLength(350)]
        public string CostCentersName { get; set; }

        public int? MainCostCentersID { get; set; }

        public decimal? Priv_Credit { get; set; }

        public decimal? Priv_Debit { get; set; }

        public string Note { get; set; }

        public int? BranchID { get; set; }

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
