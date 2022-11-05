using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newWorkRes.DAL
{
    public class TableDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        //get available tables
        public IEnumerable<Restaurant_Table> GetAvailableTables() => Context.Restaurant_Table.Where(table => table.ISPause == false);

        //get orderId of the table by tableId
        public int? GetOrderIdOfTable(int _tableId) => Context.Restaurant_Room.Where(table => table.ID == _tableId).Select(table => table.OrderID).FirstOrDefault();

        //get order of the table by table id
        public Order_Orders GetTableOrder(int _tableId)
        {
            int? OrderId = GetOrderIdOfTable(_tableId);
            return Context.Order_Orders.Where(order => order.ID == OrderId).FirstOrDefault();
        }

        //get money on the table by tableID
        public decimal? GetMoneyOnTable(int _tableId) => Context.Restaurant_Table.Where(table => table.ID == _tableId).Select(table => table.Money).FirstOrDefault();

        //check if the table is pause by table ID
        public bool IfTableISPause(int _tableId)
        {
            Restaurant_Table TableToChecked = Context.Restaurant_Table.Where(table => table.ID == _tableId).FirstOrDefault();
            if (TableToChecked.ISPause == false)
                return false;
            else
                return true;
        }
    }
}