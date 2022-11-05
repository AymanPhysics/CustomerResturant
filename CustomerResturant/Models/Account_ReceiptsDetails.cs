namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_ReceiptsDetails
    {
        [Key]
        public int Sn { get; set; }

        public int? TranSn { get; set; }

        public int? Account_Sn { get; set; }

        public int? AccounIindex { get; set; }

        [StringLength(4000)]
        public string TranDesc { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public int? CostCentersID { get; set; }

        public int? BranchID { get; set; }

        public virtual Account_Receipts Account_Receipts { get; set; }
    }
}
