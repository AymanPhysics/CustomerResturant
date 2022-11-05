namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyData")]
    public partial class CompanyData
    {
        [Key]
        public byte CompanyID { get; set; }

        public string CompanyName { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        public string Address { get; set; }

        public bool? YearEndClosing { get; set; }

        public byte? Currency_Dividing { get; set; }

        public byte? Quantities { get; set; }

        public byte? TrayClosing { get; set; }

        public bool? SelectPrinterBeforePrintingSales { get; set; }

        public bool? SalesRemoveDuplicates { get; set; }

        public bool? SalesDoNotChangeDate { get; set; }

        public bool? MustSalesMan { get; set; }

        public bool? AttentionWhenAnegativeFundBalance { get; set; }

        public bool? AlertInCaseProfitsAndLossesToLosses { get; set; }

        public bool? AttentionCustomerWhoStoppedDealingWithUsSinceNumberOfDays { get; set; }

        public bool? Attention_on_The_items_Which_Cause_losses { get; set; }

        public bool? SalesMustCostCentersNo { get; set; }

        public bool? SalesMustDocCode { get; set; }

        public bool? SalesMustNote { get; set; }

        public bool? SalesOpeningMore { get; set; }

        public bool? SelectPrinterBeforePrintingSalesReturn { get; set; }

        public bool? SalesReturnOpeningMore { get; set; }

        public bool? SalesReturnDiscount { get; set; }

        public bool? SalesReturnDoNotChangeDate { get; set; }

        public bool? SalesReturnDoNotChangeStoreName { get; set; }

        public bool? SalesReturnDoNotChangeItemsUnits { get; set; }

        public bool? SelectPrinterBeforePrintingPurchases { get; set; }

        public bool? DoNotShowAccountTranPurchases { get; set; }

        public bool? PurchasesOpeningMore { get; set; }

        public bool? PurchasesDoNotChangeDate { get; set; }

        public bool? PurchasesMustCostCentersNo { get; set; }

        public bool? PurchasesMustDocCode { get; set; }

        public bool? PurchasesMustNote { get; set; }

        public bool? MessageIFLastSalePriceChange { get; set; }

        public bool? SelectPrinterBeforePrintingPurchasesReturn { get; set; }

        public bool? PurchasesReturnDoNotChangeItemsUnits { get; set; }

        public bool? PurchasesReturnDoNotChangeStoreName { get; set; }

        public bool? PurchasesReturnDoNotChangeDate { get; set; }

        public bool? PurchasesReturnDiscount { get; set; }

        public bool? PurchasesReturnOpeningMore { get; set; }

        public bool? SaleInvoiceWithoutValue { get; set; }

        public bool? FirewallEnabled { get; set; }

        public string FilePath { get; set; }

        public bool? backupGroupedInOneFile { get; set; }

        public bool? TakeBackupOnExitAutomatically { get; set; }

        public bool? SaveOnCloudComputing { get; set; }

        public bool? AutomaticBackupDatabase { get; set; }

        public byte? EachNumberHoursBackup { get; set; }

        public bool? DeleteOldBackupDatabase { get; set; }

        public byte? EachNumberHoursDeleteOldBackup { get; set; }

        public long? CashierCategoriesColor { get; set; }

        public long? CashierCategoriesBackColor { get; set; }

        public long? CashierCategoriesBorderColor { get; set; }

        public long? CashierCategoriesItemSize { get; set; }

        public long? CashierCategoriesForeColor { get; set; }

        public long? CashierItemsColor { get; set; }

        public long? CashierItemsBackColor { get; set; }

        public long? CashierItemsBorderColor { get; set; }

        public long? CashierItemsForeColor { get; set; }

        public string CashierItemsForeColorUI { get; set; }

        public long? CashierItemsItemSize { get; set; }

        public long? IntervalMinutes { get; set; }

        public string SaleInvoiceValue { get; set; }

        public bool? CustomCashier { get; set; }

        public bool? ShowAmountPaid { get; set; }

        public bool? SalesMultiPay { get; set; }

        public bool? IsPrint { get; set; }

        [StringLength(150)]
        public string IsPrintText { get; set; }

        public bool? SalesReturnMultiPay { get; set; }

        public bool? ItemCodeFocus { get; set; }

        public bool? ISRestaurant { get; set; }

        public bool? AddUserPriceSeller { get; set; }

        public string license { get; set; }

        public double? FineReturn { get; set; }

        public bool? VAT_Flage { get; set; }

        public int? branchsconectiontype { get; set; }

        public string time1 { get; set; }

        public string time2 { get; set; }

        public string VAT_ID { get; set; }

        public bool? purchasevatflage { get; set; }
    }
}
