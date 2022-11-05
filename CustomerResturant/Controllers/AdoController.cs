using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CustomerResturant.Controllers
{
    public class AdoController : ApiController
    {
        BasicMethods bm = new BasicMethods();


        [HttpGet]
        public DataTable GetBranches()
        {
            return bm.ExecuteAdapter("select Id,Name from Account_Branch union select 0,'Please, select'");
        }


        [HttpGet]
        public DataTable GetUsers(String BranchId)
        {
            return bm.ExecuteAdapter("select Id,Name from User_Login where BranchID='" + BranchId + "' union select 0,'Please, select'");
        }

        [HttpGet]
        public DataTable GetRooms(String BranchId)
        {
            return bm.ExecuteAdapter("select ID,Name,ISPause,Money from Restaurant_Room where BranchID='" + BranchId + "'");
        }

        [HttpGet]
        public DataTable GetTables(String BranchId)
        {
            return bm.ExecuteAdapter("select ID,Name,ISPause,Money from Restaurant_Table where BranchID='" + BranchId + "'");
        }

        [HttpGet]
        public DataTable GetDeliveryMan(String BranchId)
        {
            return bm.ExecuteAdapter("select ID,DeliveryName Name from Restaurant_DeliveryMan where BranchID="+BranchId);
        }

        [HttpGet]
        public DataTable GetItemsByCategoryID(String CategoryId)
        {
            return bm.ExecuteAdapter("select * from Item_Items where Category_ID=" + CategoryId);
        }

        [HttpPost]
        public int Mob_Order_Save(
            int BranchID,
            int SupplierID,
            bool IsWaiting ,
            string SupplierName ,
            string SupplierPhone ,
            string SupplierVatNum,
            DateTime Purchases_Date ,
            int Order_Paymant_Type,
            string Restaurant_PayType,
            int Restaurant_TypeID ,
            int CostCentersID,
            string Note,
            string NoteNum,
            decimal CostOrder ,
            decimal Tax  ,
            decimal TotalPrices,
            decimal Safy,
            decimal DiscountNum,
            decimal DiscountPerantage,
            decimal Tax_Discount,
            decimal TotalPrices_Discount,
            decimal TobaccoTax,
            decimal AllTax,
            decimal Net,
            decimal CashMoney,
            decimal CashBank,
            bool OrderCashierType ,
            int RoomNum,
            int TableNum,
            int UserID_Add,
            int UserBranch_Add,
            string UserMacAddress_Add,
            DateTime UserDate_Add,
            int UserID_Update,
            int UserBranch_Update,
            string UserMacAddress_Update,
            DateTime UserDate_Update,
            [FromBody] Order_OrdersDetails[] order_OrdersDetails)
        {
            DataTable Tbl_order_OrdersDetails = new DataTable();

            string[] ParaName = {"BranchID","SupplierID","IsWaiting","SupplierName","SupplierPhone","SupplierVatNum","Purchases_Date","Order_Paymant_Type","Restaurant_PayType","Restaurant_TypeID","CostCentersID","Note","NoteNum","CostOrder" ,"Tax","TotalPrices","Safy","DiscountNum","DiscountPerantage","Tax_Discount","TotalPrices_Discount","TobaccoTax","AllTax","Net","CashMoney","CashBank","OrderCashierType","RoomNum","TableNum","UserID_Add","UserBranch_Add","UserMacAddress_Add","UserDate_Add","UserID_Update","UserBranch_Update","UserMacAddress_Update","UserDate_Update", "order_OrdersDetails" };
            Object [] ParaValue = { BranchID,SupplierID,IsWaiting,SupplierName,SupplierPhone,SupplierVatNum,DateTime.Now.ToString (), Order_Paymant_Type, Restaurant_PayType,Restaurant_TypeID, CostCentersID.ToString (),Note,NoteNum,CostOrder, Tax, TotalPrices, Safy, DiscountNum, DiscountPerantage, Tax_Discount, TotalPrices_Discount, TobaccoTax, AllTax, Net, CashMoney, CashBank, OrderCashierType, RoomNum, TableNum, UserID_Add, UserBranch_Add, UserMacAddress_Add, UserDate_Add, UserID_Update, UserBranch_Update, UserMacAddress_Update, UserDate_Update, Tbl_order_OrdersDetails };
            SqlDbType[] ParaType  = {SqlDbType.Int ,
            SqlDbType.Int,
            SqlDbType.Bit ,
            SqlDbType.VarChar,
            SqlDbType.VarChar,
            SqlDbType.VarChar,
            SqlDbType.DateTime ,
            SqlDbType.Int ,
            SqlDbType.VarChar,
            SqlDbType.Int ,
            SqlDbType.Int ,
            SqlDbType.VarChar,
            SqlDbType.VarChar,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Decimal ,
            SqlDbType.Bit,
            SqlDbType.Int ,
            SqlDbType.Int ,
            SqlDbType.Int ,
            SqlDbType.Int ,
            SqlDbType.VarChar,
            SqlDbType.DateTime ,
            SqlDbType.Int ,
            SqlDbType.Int ,
            SqlDbType.VarChar ,
            SqlDbType.DateTime ,
                SqlDbType.Structured };
            bm.ExecuteScalar("Mob_Order_Save", ParaName, ParaValue,ParaType );

            return 0;
        }

    }
}