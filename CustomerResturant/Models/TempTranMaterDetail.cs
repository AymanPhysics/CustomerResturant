namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TempTranMaterDetail
    {
        [Column(TypeName = "numeric")]
        public decimal TranSn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Account_Sn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Account_No { get; set; }

        public short? TranTypeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TranCode { get; set; }

        public DateTime? TranDate { get; set; }

        [StringLength(50)]
        public string TranTypeDesc { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReferenceCode { get; set; }

        [StringLength(4000)]
        public string TranDesc { get; set; }

        public decimal? Debit { get; set; }

        public decimal? Credit { get; set; }

        public decimal? Priv_Debit { get; set; }

        public decimal? Priv_Credit { get; set; }

        public decimal? SumValues { get; set; }

        public decimal? Balance { get; set; }

        [StringLength(350)]
        public string Account_Name { get; set; }

        public short? AccounIindex { get; set; }

        [StringLength(200)]
        public string ReceivedFrom { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal IDCount { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CostCentersNo { get; set; }

        [StringLength(350)]
        public string CostCentersName { get; set; }

        public decimal? running_total { get; set; }

        [StringLength(50)]
        public string DocCode { get; set; }

        public Guid? LedgerID { get; set; }

        public int? BranchID { get; set; }

        public int? UserID { get; set; }
    }
}
