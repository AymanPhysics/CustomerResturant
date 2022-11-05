CREATE type View_Order_OrdersDetails
as table (
	[SN] [int] IDENTITY(1,1) NOT NULL,
	[Purchese_ID] [int] NULL,
	[ItemID] [int] NULL,
	[BranchID] [int] NULL,
	[IsWaiting] [bit] NULL,
	[StoreID] [int] NULL,
	[ItemUnitID] [int] NULL,
	[Quantity] [decimal](18, 3) NULL,
	[LastCost] [decimal](18, 3) NULL,
	[SmallUnitPrice] [decimal](18, 3) NULL,
	[UnitPrice] [decimal](18, 3) NULL,
	[TotalPrice] [decimal](18, 3) NULL,
	[VAT] [decimal](18, 3) NULL,
	[NetUnitPrice] [decimal](18, 3) NULL,
	[NetTotalPrice] [decimal](18, 3) NULL,
	[VAT_Discount] [decimal](18, 3) NULL,
	[ItemUnitType] [nvarchar](150) NULL,
	[IsPrint] [bit] NULL
) 

