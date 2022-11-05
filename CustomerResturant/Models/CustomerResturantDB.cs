namespace CustomerResturant.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerResturantDB : DbContext
    {
        public CustomerResturantDB()
            : base("name=CustomerResturantDB")
        {
        }

        public virtual DbSet<Account_Accounts> Account_Accounts { get; set; }
        public virtual DbSet<Account_AccountType> Account_AccountType { get; set; }
        public virtual DbSet<Account_Branch> Account_Branch { get; set; }
        public virtual DbSet<Account_CostCenters> Account_CostCenters { get; set; }
        public virtual DbSet<Account_CustSup> Account_CustSup { get; set; }
        public virtual DbSet<Account_DefualtAccount> Account_DefualtAccount { get; set; }
        public virtual DbSet<Account_DefualtAccount2> Account_DefualtAccount2 { get; set; }
        public virtual DbSet<Account_DefualtCustomer> Account_DefualtCustomer { get; set; }
        public virtual DbSet<Account_Final> Account_Final { get; set; }
        public virtual DbSet<Account_Nature> Account_Nature { get; set; }
        public virtual DbSet<Account_Place> Account_Place { get; set; }
        public virtual DbSet<Account_Receipts> Account_Receipts { get; set; }
        public virtual DbSet<Account_ReceiptsDetails> Account_ReceiptsDetails { get; set; }
        public virtual DbSet<Account_SalesMan> Account_SalesMan { get; set; }
        public virtual DbSet<Account_Stores> Account_Stores { get; set; }
        public virtual DbSet<Account_Suspended> Account_Suspended { get; set; }
        public virtual DbSet<Account_Type> Account_Type { get; set; }
        public virtual DbSet<AccountStartBalance> AccountStartBalances { get; set; }
        public virtual DbSet<CashReceiptsType> CashReceiptsTypes { get; set; }
        public virtual DbSet<CompanyData> CompanyDatas { get; set; }
        public virtual DbSet<Contract_Contract> Contract_Contract { get; set; }
        public virtual DbSet<Contract_ContractDetails> Contract_ContractDetails { get; set; }
        public virtual DbSet<Contract_Guarantee> Contract_Guarantee { get; set; }
        public virtual DbSet<Contract_GuaranteeDetails> Contract_GuaranteeDetails { get; set; }
        public virtual DbSet<Contract_Store> Contract_Store { get; set; }
        public virtual DbSet<Emp_Employee> Emp_Employee { get; set; }
        public virtual DbSet<Emp_Payroll> Emp_Payroll { get; set; }
        public virtual DbSet<Emp_PayrollDetails> Emp_PayrollDetails { get; set; }
        public virtual DbSet<Emp_PayrollTemp> Emp_PayrollTemp { get; set; }
        public virtual DbSet<Emp_PayrollTempDetails> Emp_PayrollTempDetails { get; set; }
        public virtual DbSet<Item_Class> Item_Class { get; set; }
        public virtual DbSet<Item_Company> Item_Company { get; set; }
        public virtual DbSet<Item_Country> Item_Country { get; set; }
        public virtual DbSet<Item_Groups> Item_Groups { get; set; }
        public virtual DbSet<Item_Guarantee> Item_Guarantee { get; set; }
        public virtual DbSet<Item_ItemComponent> Item_ItemComponent { get; set; }
        public virtual DbSet<Item_Items> Item_Items { get; set; }
        public virtual DbSet<Item_Type> Item_Type { get; set; }
        public virtual DbSet<Item_Unit> Item_Unit { get; set; }
        public virtual DbSet<ItemQuantity> ItemQuantities { get; set; }
        public virtual DbSet<Items_ContentAlignment_ForCashier> Items_ContentAlignment_ForCashier { get; set; }
        public virtual DbSet<Order_CheckoutOrders> Order_CheckoutOrders { get; set; }
        public virtual DbSet<Order_CheckoutOrdersDetails> Order_CheckoutOrdersDetails { get; set; }
        public virtual DbSet<Order_InventorySettlementMinus> Order_InventorySettlementMinus { get; set; }
        public virtual DbSet<Order_InventorySettlementMinusDetails> Order_InventorySettlementMinusDetails { get; set; }
        public virtual DbSet<Order_OpenQuantity> Order_OpenQuantity { get; set; }
        public virtual DbSet<Order_OpenQuantityDetails> Order_OpenQuantityDetails { get; set; }
        public virtual DbSet<Order_OrderReturn> Order_OrderReturn { get; set; }
        public virtual DbSet<Order_OrderReturnDetails> Order_OrderReturnDetails { get; set; }
        public virtual DbSet<Order_Orders> Order_Orders { get; set; }
        public virtual DbSet<Order_OrdersDetails> Order_OrdersDetails { get; set; }
        public virtual DbSet<Order_PriceOffer> Order_PriceOffer { get; set; }
        public virtual DbSet<Order_PriceOfferDetails> Order_PriceOfferDetails { get; set; }
        public virtual DbSet<Order_Purchases> Order_Purchases { get; set; }
        public virtual DbSet<Order_PurchasesDetails> Order_PurchasesDetails { get; set; }
        public virtual DbSet<Order_PurchasesOrder> Order_PurchasesOrder { get; set; }
        public virtual DbSet<Order_PurchasesOrderDetails> Order_PurchasesOrderDetails { get; set; }
        public virtual DbSet<Order_PurchasesReturn> Order_PurchasesReturn { get; set; }
        public virtual DbSet<Order_PurchasesReturnDetails> Order_PurchasesReturnDetails { get; set; }
        public virtual DbSet<Order_StoreTransfer> Order_StoreTransfer { get; set; }
        public virtual DbSet<Order_StoreTransferDetails> Order_StoreTransferDetails { get; set; }
        public virtual DbSet<Printer> Printers { get; set; }
        public virtual DbSet<Restaurant_Delivery> Restaurant_Delivery { get; set; }
        public virtual DbSet<Restaurant_DeliveryMan> Restaurant_DeliveryMan { get; set; }
        public virtual DbSet<Restaurant_Room> Restaurant_Room { get; set; }
        public virtual DbSet<Restaurant_Table> Restaurant_Table { get; set; }
        public virtual DbSet<Restaurant_Type> Restaurant_Type { get; set; }
        public virtual DbSet<Tafqit> Tafqits { get; set; }
        public virtual DbSet<TblSetting> TblSettings { get; set; }
        public virtual DbSet<Temp_Accounts> Temp_Accounts { get; set; }
        public virtual DbSet<TempTranMaterDetail> TempTranMaterDetails { get; set; }
        public virtual DbSet<TempTrialBalanceByTotal> TempTrialBalanceByTotals { get; set; }
        public virtual DbSet<Tran_Tran> Tran_Tran { get; set; }
        public virtual DbSet<Tran_TranDetails> Tran_TranDetails { get; set; }
        public virtual DbSet<Tran_TranTemp> Tran_TranTemp { get; set; }
        public virtual DbSet<Tran_TranTempDetails> Tran_TranTempDetails { get; set; }
        public virtual DbSet<Tran_Type> Tran_Type { get; set; }
        public virtual DbSet<User_Groups> User_Groups { get; set; }
        public virtual DbSet<User_Login> User_Login { get; set; }
        public virtual DbSet<User_Permission> User_Permission { get; set; }
        public virtual DbSet<User_Screens> User_Screens { get; set; }
        public virtual DbSet<User_SellPrice> User_SellPrice { get; set; }
        public virtual DbSet<ItemQuantityExpire> ItemQuantityExpires { get; set; }
        public virtual DbSet<TempAccount> TempAccounts { get; set; }
        public virtual DbSet<TempBudget> TempBudgets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account_Accounts>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_Accounts>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_CostCenters>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_CostCenters>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_CustSup>()
                .Property(e => e.CreditLimit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_CustSup>()
                .Property(e => e.AlarmLimit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_Receipts>()
                .Property(e => e.Money)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_Receipts>()
                .Property(e => e.TranCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Account_Receipts>()
                .HasMany(e => e.Account_ReceiptsDetails)
                .WithOptional(e => e.Account_Receipts)
                .HasForeignKey(e => e.TranSn);

            modelBuilder.Entity<Account_ReceiptsDetails>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_ReceiptsDetails>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_SalesMan>()
                .Property(e => e.profit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Account_Stores>()
                .HasMany(e => e.ItemQuantities)
                .WithOptional(e => e.Account_Stores)
                .HasForeignKey(e => e.StoreID);

            modelBuilder.Entity<Account_Type>()
                .HasMany(e => e.Account_Accounts)
                .WithOptional(e => e.Account_Type1)
                .HasForeignKey(e => e.Account_Type);

            modelBuilder.Entity<AccountStartBalance>()
                .Property(e => e.AccountNo)
                .HasPrecision(18, 5);

            modelBuilder.Entity<AccountStartBalance>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 5);

            modelBuilder.Entity<AccountStartBalance>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.CostOrder)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Contract>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_ContractDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.CostOrder)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Guarantee>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.QuantityExpire)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_GuaranteeDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Store>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Contract_Store>()
                .Property(e => e.QuantityExpire)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_Employee>()
                .Property(e => e.Money)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.Salary)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.DaysOfBsence)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.DaysExtra)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.PaymentOfAdvance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.Deduct)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.Merit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollDetails>()
                .Property(e => e.NetSalary)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.Salary)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.DaysOfBsence)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.DaysExtra)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.PaymentOfAdvance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.Deduct)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.Merit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Emp_PayrollTempDetails>()
                .Property(e => e.NetSalary)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_ItemComponent>()
                .Property(e => e.Amount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_ItemComponent>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_ItemComponent>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceSmall)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceSmall2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceSmall3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.Average_cost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceExportunit1)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceMowazaunit1)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SmallUnitQuantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.ConvertMediumUnit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceMedium)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceMedium2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellPriceMedium3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.LastCost2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceExportunit2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceMowazaunit2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SmallUnitQuantity2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.ConvertBigUnit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellpriceLarge)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellpriceLarge2)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SellpriceLarge3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.LastCost3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceExportunit3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceMowazaunit3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.SmallUnitQuantity3)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.NumOffer)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.PriceOffer)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Items>()
                .Property(e => e.Tax_Value)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Item_Unit>()
                .HasMany(e => e.Item_Items)
                .WithOptional(e => e.Item_Unit)
                .HasForeignKey(e => e.UnitSmall);

            modelBuilder.Entity<Item_Unit>()
                .HasMany(e => e.Item_Items1)
                .WithOptional(e => e.Item_Unit1)
                .HasForeignKey(e => e.UnitMedium);

            modelBuilder.Entity<Item_Unit>()
                .HasMany(e => e.Item_Items2)
                .WithOptional(e => e.Item_Unit2)
                .HasForeignKey(e => e.UnitLarge);

            modelBuilder.Entity<Item_Unit>()
                .HasMany(e => e.Order_PurchasesDetails)
                .WithOptional(e => e.Item_Unit)
                .HasForeignKey(e => e.ItemUnitID);

            modelBuilder.Entity<Item_Unit>()
                .HasMany(e => e.Order_PurchasesOrderDetails)
                .WithOptional(e => e.Item_Unit)
                .HasForeignKey(e => e.ItemUnitID);

            modelBuilder.Entity<ItemQuantity>()
                .Property(e => e.OpeningBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ItemQuantity>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ItemQuantity>()
                .Property(e => e.BeginningInventory)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ItemQuantity>()
                .Property(e => e.BeginningInventoryPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.CostAverg)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.TobaccoTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrders>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.CostAverg)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_CheckoutOrdersDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_InventorySettlementMinus>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_InventorySettlementMinusDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_InventorySettlementMinusDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_InventorySettlementMinusDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_InventorySettlementMinusDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OpenQuantity>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OpenQuantity>()
                .HasMany(e => e.Order_OpenQuantityDetails)
                .WithOptional(e => e.Order_OpenQuantity)
                .HasForeignKey(e => e.Purchese_ID);

            modelBuilder.Entity<Order_OpenQuantityDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OpenQuantityDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OpenQuantityDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OpenQuantityDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.CostAverg)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.TobaccoTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturn>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.CostAverg)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrderReturnDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.CostOrder)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.TobaccoTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.CashMoney)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Orders>()
                .Property(e => e.CashBank)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_OrdersDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.TobaccoTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.AllTax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOffer>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.LastCost)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PriceOfferDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_Purchases>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrder>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesOrderDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.Tax)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.TotalPrices)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.Safy)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.DiscountNum)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.DiscountPerantage)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.Tax_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.TotalPrices_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturn>()
                .Property(e => e.Net)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.VAT)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.NetUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.NetTotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_PurchasesReturnDetails>()
                .Property(e => e.VAT_Discount)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_StoreTransferDetails>()
                .Property(e => e.Quantity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_StoreTransferDetails>()
                .Property(e => e.SmallUnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_StoreTransferDetails>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Order_StoreTransferDetails>()
                .Property(e => e.TotalPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Restaurant_Delivery>()
                .Property(e => e.Money)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Restaurant_Room>()
                .Property(e => e.Money)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Restaurant_Table>()
                .Property(e => e.Money)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Temp_Accounts>()
                .Property(e => e.Temp_Account_Sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.TranSn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Account_Sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Account_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.TranCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.ReferenceCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.SumValues)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.Balance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.IDCount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.CostCentersNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTranMaterDetail>()
                .Property(e => e.running_total)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Account_Sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Account_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.SumValues)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.TotalDebitBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.TotalCreditBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.DebitBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempTrialBalanceByTotal>()
                .Property(e => e.CreditBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Tran_Tran>()
                .Property(e => e.TranCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Tran_TranDetails>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Tran_TranDetails>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Tran_TranTempDetails>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Tran_TranTempDetails>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<ItemQuantityExpire>()
                .Property(e => e.CurrentBalance)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempAccount>()
                .Property(e => e.sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempAccount>()
                .Property(e => e.Account_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempAccount>()
                .Property(e => e.Main_Account_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempAccount>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TempAccount>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.TranSn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Account_Sn)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Account_No)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.TranCode)
                .IsUnicode(false);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.ReferenceCode)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Priv_Debit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Priv_Credit)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.SumValues)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TempBudget>()
                .Property(e => e.Balance)
                .HasPrecision(18, 3);
        }
    }
}
