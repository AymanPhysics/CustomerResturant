namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Item_Unit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item_Unit()
        {
            Item_Items = new HashSet<Item_Items>();
            Item_Items1 = new HashSet<Item_Items>();
            Item_Items2 = new HashSet<Item_Items>();
            Order_PurchasesDetails = new HashSet<Order_PurchasesDetails>();
            Order_PurchasesOrderDetails = new HashSet<Order_PurchasesOrderDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

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
        public virtual ICollection<Item_Items> Item_Items { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Items> Item_Items1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item_Items> Item_Items2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_PurchasesDetails> Order_PurchasesDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_PurchasesOrderDetails> Order_PurchasesOrderDetails { get; set; }
    }
}
