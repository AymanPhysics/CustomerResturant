namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_Receipts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account_Receipts()
        {
            Account_ReceiptsDetails = new HashSet<Account_ReceiptsDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ReferenceCode { get; set; }

        public int? TranTypeID { get; set; }

        public int? CashReceiptsTypeID { get; set; }

        [StringLength(50)]
        public string DocCode { get; set; }

        public DateTime? TranDate { get; set; }

        [StringLength(200)]
        public string ReceivedFrom { get; set; }

        [StringLength(4000)]
        public string Note { get; set; }

        public decimal? Money { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? TranCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account_ReceiptsDetails> Account_ReceiptsDetails { get; set; }
    }
}
