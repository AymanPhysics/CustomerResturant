namespace CustomerResturant.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_DefualtAccount
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? BranchID { get; set; }

        public int? Acc_StoreMain { get; set; }

        public int? Acc_StoreWaiting { get; set; }

        public int? Acc_CostItemOrder { get; set; }

        public int? Acc_VatNum { get; set; }

        public int? Acc_CashBox { get; set; }

        public int? Acc_OrderCash { get; set; }

        public int? Acc_OrderAjila { get; set; }

        public int? Acc_OrderReturnCash { get; set; }

        public int? Acc_BankNumCachir { get; set; }

        public int? Acc_CustomerCash { get; set; }

        public int? Acc_supplierCash { get; set; }

        public int? StoreEntagTam { get; set; }

        public int? StoreMawadAwalyaa { get; set; }
    }
}
