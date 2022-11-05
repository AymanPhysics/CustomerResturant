namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountStartBalance")]
    public partial class AccountStartBalance
    {
        public int Id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AccountNo { get; set; }

        public decimal? Priv_Debit { get; set; }

        public decimal? Priv_Credit { get; set; }

        public int CompID { get; set; }

        public DateTime? StartDate { get; set; }

        public int? CreatedBy { get; set; }

        public bool? AllowEdit { get; set; }
    }
}
