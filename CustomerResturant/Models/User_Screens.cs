namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Screens
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Screen_Name { get; set; }

        public int? ScreenTypeID { get; set; }

        public int? ScreenNum { get; set; }

        [StringLength(50)]
        public string ScreenTypeName { get; set; }

        public bool? ISShow { get; set; }
    }
}
