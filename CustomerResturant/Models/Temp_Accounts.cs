namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Temp_Accounts
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal Temp_Account_Sn { get; set; }
    }
}
