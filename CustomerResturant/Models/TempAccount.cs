namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TempAccount
    {
        [Key]
        [Column(TypeName = "numeric")]
        public decimal sn { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Account_No { get; set; }

        public short? Suspended { get; set; }

        public short? Account_Level { get; set; }

        public short? Final_Account { get; set; }

        public short? Account_Type { get; set; }

        public short? Account_Nature { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Main_Account_No { get; set; }

        [StringLength(350)]
        public string Account_Name { get; set; }

        [StringLength(350)]
        public string E_Account_Name { get; set; }

        [Column(TypeName = "money")]
        public decimal? Priv_Debit { get; set; }

        [Column(TypeName = "money")]
        public decimal? Priv_Credit { get; set; }

        [StringLength(350)]
        public string AddressA { get; set; }

        [StringLength(350)]
        public string AddressB { get; set; }

        [StringLength(50)]
        public string PhoneA { get; set; }

        [StringLength(50)]
        public string PhoneB { get; set; }

        [StringLength(50)]
        public string FaxA { get; set; }

        [StringLength(50)]
        public string FaxB { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? CreatedByUser { get; set; }

        public int? UpdatedByUser { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
