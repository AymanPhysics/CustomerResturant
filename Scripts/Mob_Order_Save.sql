alter proc Mob_Order_Save
@BranchID int ,
@SupplierID int ,
@IsWaiting bit ,
@SupplierName nvarchar(max) ,
@SupplierPhone nvarchar(50) ,
@SupplierVatNum nvarchar(150) ,
@Purchases_Date datetime ,
@Order_Paymant_Type int ,
@Restaurant_PayType nvarchar(100) ,
@Restaurant_TypeID int ,
@CostCentersID int ,
@Note nvarchar(max) ,
@NoteNum nvarchar(50) ,
@CostOrder decimal(18, 3) ,
@Tax decimal(18, 3) ,
@TotalPrices decimal(18, 3) ,
@Safy decimal(18, 3) ,
@DiscountNum decimal(18, 3) ,
@DiscountPerantage decimal(18, 3) ,
@Tax_Discount decimal(18, 3) ,
@TotalPrices_Discount decimal(18, 3) ,
@TobaccoTax decimal(18, 3) ,
@AllTax decimal(18, 3) ,
@Net decimal(18, 3) ,
@CashMoney decimal(18, 3) ,
@CashBank decimal(18, 3) ,
@OrderCashierType bit ,
@RoomNum int ,
@TableNum int ,
@UserID_Add int ,
@UserBranch_Add int ,
@UserMacAddress_Add nvarchar(100) ,
@UserDate_Add datetime ,
@UserID_Update int ,
@UserBranch_Update int ,
@UserMacAddress_Update nvarchar(100) ,
@UserDate_Update datetime ,
@Order_OrdersDetails as View_Order_OrdersDetails readonly

as

declare @ID bigint =isnull((select max(ID) from Order_Orders),0)+1

declare @PurBranchID bigint =isnull((select max(ID) from Order_Orders where BranchID=@BranchID),0)+1

INSERT INTO [dbo].[Order_Orders]
([ID]
,[PurBranchID]
,[BranchID]
,[SupplierID]
,[IsWaiting]
,[SupplierName]
,[SupplierPhone]
,[SupplierVatNum]
,[Purchases_Date]
,[Order_Paymant_Type]
,[Restaurant_PayType]
,[Restaurant_TypeID]
,[CostCentersID]
,[Note]
,[NoteNum]
,[CostOrder]
,[Tax]
,[TotalPrices]
,[Safy]
,[DiscountNum]
,[DiscountPerantage]
,[Tax_Discount]
,[TotalPrices_Discount]
,[TobaccoTax]
,[AllTax]
,[Net]
,[CashMoney]
,[CashBank]
,[OrderCashierType]
,[RoomNum]
,[TableNum]
,[UserID_Add]
,[UserBranch_Add]
,[UserMacAddress_Add]
,[UserDate_Add]
,[UserID_Update]
,[UserBranch_Update]
,[UserMacAddress_Update]
,[UserDate_Update]
)
select 
@ID ,
@PurBranchID ,
@BranchID ,
@SupplierID ,
@IsWaiting  ,
@SupplierName ,
@SupplierPhone ,
@SupplierVatNum ,
@Purchases_Date ,
@Order_Paymant_Type ,
@Restaurant_PayType ,
@Restaurant_TypeID ,
@CostCentersID ,
@Note  ,
@NoteNum ,
@CostOrder  ,
@Tax  ,
@TotalPrices ,
@Safy ,
@DiscountNum ,
@DiscountPerantage ,
@Tax_Discount ,
@TotalPrices_Discount ,
@TobaccoTax ,
@AllTax ,
@Net ,
@CashMoney ,
@CashBank ,
@OrderCashierType ,
@RoomNum ,
@TableNum ,
@UserID_Add ,
@UserBranch_Add ,
@UserMacAddress_Add ,
@UserDate_Add ,
@UserID_Update ,
@UserBranch_Update ,
@UserMacAddress_Update ,
@UserDate_Update 



declare
@SN int =isnull((select max(SN) from Order_OrdersDetails),0)+1


insert Order_OrdersDetails
select 
@PurBranchID
,[ItemID]
,[BranchID]
,[IsWaiting]
,[StoreID]
,[ItemUnitID]
,[Quantity]
,[LastCost]
,[SmallUnitPrice]
,[UnitPrice]
,[TotalPrice]
,[VAT]
,[NetUnitPrice]
,[NetTotalPrice]
,[VAT_Discount]
,[ItemUnitType]
,[IsPrint]
from @Order_OrdersDetails





select @PurBranchID