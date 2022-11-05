namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_Branch
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int? AccountNo { get; set; }

        [StringLength(25)]
        public string Phone { get; set; }

        [StringLength(25)]
        public string Fax { get; set; }

        [StringLength(350)]
        public string Address { get; set; }

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
