namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Permission
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? ScreenID { get; set; }

        public int? GroupID { get; set; }

        public bool? Allow_Branch { get; set; }

        public bool? Allow_Enter { get; set; }

        public bool? Allow_Save { get; set; }

        public bool? Allow_Edit { get; set; }

        public bool? Allow_Delete { get; set; }

        public bool? Allow_Print { get; set; }

        public bool? Allow_Export { get; set; }

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
