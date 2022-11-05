namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TempTrialBalanceByTotal")]
    public partial class TempTrialBalanceByTotal
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal Account_Sn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Account_No { get; set; }

        [StringLength(350)]
        public string Account_Name { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Priv_Credit { get; set; }

        public decimal? Priv_Debit { get; set; }

        public decimal? SumValues { get; set; }

        public decimal? TotalDebitBalance { get; set; }

        public decimal? TotalCreditBalance { get; set; }

        public decimal? DebitBalance { get; set; }

        public decimal? CreditBalance { get; set; }

        public int? BranchID { get; set; }

        public int? UserID { get; set; }
    }
}
