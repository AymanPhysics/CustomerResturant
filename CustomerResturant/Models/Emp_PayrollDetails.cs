namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_PayrollDetails
    {
        [Key]
        public int SN { get; set; }

        public int? PayRollID { get; set; }

        public int? AccountNum { get; set; }

        public int? EmpID { get; set; }

        public decimal? Salary { get; set; }

        public int? AccountBankBox { get; set; }

        public decimal? DaysOfBsence { get; set; }

        public decimal? DaysExtra { get; set; }

        public decimal? PaymentOfAdvance { get; set; }

        public decimal? Deduct { get; set; }

        public decimal? Merit { get; set; }

        public decimal? NetSalary { get; set; }

        public int? CostCentersID { get; set; }
    }
}
