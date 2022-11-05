namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_OpenQuantity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order_OpenQuantity()
        {
            Order_OpenQuantityDetails = new HashSet<Order_OpenQuantityDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? PurBranchID { get; set; }

        public int? BranchID { get; set; }

        public DateTime? Purchases_Date { get; set; }

        [StringLength(50)]
        public string NoteNum { get; set; }

        public decimal? TotalPrices { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_OpenQuantityDetails> Order_OpenQuantityDetails { get; set; }
    }
}
