namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_CustSup
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? CustSuppCode { get; set; }

        public int? AccountNo { get; set; }

        public int? BranchID { get; set; }

        [StringLength(350)]
        public string CustSuppName { get; set; }

        [StringLength(150)]
        public string VatNum { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(25)]
        public string Fax { get; set; }

        [StringLength(350)]
        public string Address { get; set; }

        public int? PlaceID { get; set; }

        public int? SalesManID { get; set; }

        public decimal? CreditLimit { get; set; }

        public decimal? AlarmLimit { get; set; }

        public bool? IsSuppliers { get; set; }

        public bool? IsCustomers { get; set; }

        public bool? FrmCust { get; set; }

        public string Note { get; set; }

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
