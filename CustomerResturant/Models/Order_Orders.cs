namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order_Orders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? PurBranchID { get; set; }

        public int? BranchID { get; set; }

        public int? SupplierID { get; set; }

        public bool? IsWaiting { get; set; }

        public string SupplierName { get; set; }

        [StringLength(50)]
        public string SupplierPhone { get; set; }

        [StringLength(150)]
        public string SupplierVatNum { get; set; }

        public DateTime? Purchases_Date { get; set; }

        public int? Order_Paymant_Type { get; set; }

        [StringLength(100)]
        public string Restaurant_PayType { get; set; }

        public int? Restaurant_TypeID { get; set; }

        public int? CostCentersID { get; set; }

        public string Note { get; set; }

        [StringLength(50)]
        public string NoteNum { get; set; }

        public decimal? CostOrder { get; set; }

        public decimal? Tax { get; set; }

        public decimal? TotalPrices { get; set; }

        public decimal? Safy { get; set; }

        public decimal? DiscountNum { get; set; }

        public decimal? DiscountPerantage { get; set; }

        public decimal? Tax_Discount { get; set; }

        public decimal? TotalPrices_Discount { get; set; }

        public decimal? TobaccoTax { get; set; }

        public decimal? AllTax { get; set; }

        public decimal? Net { get; set; }

        public decimal? CashMoney { get; set; }

        public decimal? CashBank { get; set; }

        public bool? OrderCashierType { get; set; }

        public int? RoomNum { get; set; }

        public int? TableNum { get; set; }

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
