namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_Accounts
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Account_No { get; set; }

        public int? Suspended { get; set; }

        public int? Account_Level { get; set; }

        public int? Final_Account { get; set; }

        public int? Account_Type { get; set; }

        public int? Account_Nature { get; set; }

        public int? Main_Account_No { get; set; }

        public int? BranchID { get; set; }

        [StringLength(350)]
        public string Account_Name { get; set; }

        [StringLength(350)]
        public string E_Account_Name { get; set; }

        public decimal? Priv_Debit { get; set; }

        public decimal? Priv_Credit { get; set; }

        [StringLength(350)]
        public string AddressA { get; set; }

        [StringLength(50)]
        public string PhoneA { get; set; }

        [StringLength(50)]
        public string FaxA { get; set; }

        [StringLength(500)]
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

        public virtual Account_Type Account_Type1 { get; set; }
    }
}
