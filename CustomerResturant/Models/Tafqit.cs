namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tafqit")]
    public partial class Tafqit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Tafqit_ID { get; set; }

        [StringLength(100)]
        public string Tafqit_Name { get; set; }
    }
}
