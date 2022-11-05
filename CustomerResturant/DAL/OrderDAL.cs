using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerResturant.DAL
{
    public class OrderDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        // save any database changes :
        void SaveDBChanges()
        {
            Context.SaveChanges();
        }

        //get all orders
        public IEnumerable<Order_Orders> GetAllOrders() => Context.Order_Orders;

        // get specific order by ID :
        public Order_Orders searchOrder(int? orderID) => Context.Order_Orders.Find(orderID);

        // Get all orders for a specific customer by customer ID :
        public IEnumerable<Order_Orders> GetCustomerOrders(int customerID) => Context.Order_Orders.Where(o => o.SupplierID == customerID);

        // Get all orders by restaurant Type :
        public IEnumerable<Order_Orders> GetOrdersByRestaurantType(int resturantTypeID) => Context.Order_Orders.Where(o => o.Restaurant_TypeID == resturantTypeID);

        //Get Orders for specific room :
        public IEnumerable<Order_Orders> GetOrdersForSpecificRoom(int roomNumber) => Context.Order_Orders.Where(o => o.RoomNum == roomNumber);

        //Get Orders for specific table :
        public IEnumerable<Order_Orders> GetOrdersForSpecificTable(int tableNumber) => Context.Order_Orders.Where(o => o.TableNum == tableNumber);

        // Create new order :
        public bool CreateNewOrder (Order_Orders newOrder)
        {
            if (newOrder != null)
            {
                Context.Order_Orders.Add(newOrder);
                //Context.Entry(newOrder).State = EntityState.Added;
                SaveDBChanges();
                return true;
            }
            return false;
        }

        // Edit existed order :
        public bool EditOrder(int orderID)
        {
            Order_Orders modifiedOrder = searchOrder(orderID);
            if (modifiedOrder != null)
            {
                Context.Entry(modifiedOrder).State = EntityState.Modified;
                SaveDBChanges();
                return true;
            }
            return false;
        }

        // Delete specific order :
        public bool DeleteOrder(int orderID)
        {
            Order_Orders deletedOrder = searchOrder(orderID);
            if (deletedOrder != null)
            {
                DeleteAllOrderDetailsRecordForSpecificOrder(orderID);
                Context.Entry(deletedOrder).State = EntityState.Deleted;
                SaveDBChanges();
                return true;
            }
            return false;
        }


        //check if order is exist by order id 
        public bool IsOrderExist(int _orderId)
        {
            bool exist = false;
            foreach (var order in Context.Order_Orders.ToList())
            {
                if (order.ID == _orderId)
                {
                    exist = true;
                    break;
                }
                else
                    exist = false;
            }
            return exist;
        }


        //get orders before specific date (purchase date)
        public IEnumerable<Order_Orders> GetPreviousOrders(DateTime _date)=> Context.Order_Orders.Where(order => order.Purchases_Date < _date);

        //get orders after specific date (purchase date)
        public IEnumerable<Order_Orders> GetNextOrders(DateTime _date)=> Context.Order_Orders.Where(order => order.Purchases_Date > _date);

        //get orders between two dates
        public IEnumerable<Order_Orders> GetOrdersBetweenTwoDates(DateTime _date1, DateTime _date2)
        {
            return Context.Order_Orders.Where(order => order.Purchases_Date >= _date1 && order.Purchases_Date <= _date2);
        }


        ////////////////////////////////////////////////Order Details////////////////////////////////////////////////////

        // Get all orderDetails for specific order by ID :
        public IEnumerable<Order_OrdersDetails> GetAllOrderDetails(int orderID) => Context.Order_OrdersDetails.Where(o => o.Purchese_ID == orderID);


        //get all order details
        public IEnumerable<Order_OrdersDetails> GellAllOrderDetails() => Context.Order_OrdersDetails;

        // search all order details by order ID :
        public IEnumerable<Order_OrdersDetails> GetOrderDetails(int orderID) => Context.Order_OrdersDetails.Where(o => o.Purchese_ID == orderID);


        public bool IsOrderDetailsExist(int? Purchese_ID)
        {
            bool exist = false;
            foreach (var orderDetails in Context.Order_OrdersDetails.ToList())
            {
                if (orderDetails.Purchese_ID == Purchese_ID)
                {
                    exist = true;
                    break;
                }
                else
                    exist = false;
            }
            return exist;
        }


        // get details for specifi order by order id
        public Order_OrdersDetails GetTheOrderDetails(int _orderId) => Context.Order_OrdersDetails.Where(od => od.Purchese_ID == _orderId).FirstOrDefault();


        // search Existed OrderDetails Record :
        public Order_OrdersDetails SearchOrderDetailsRecord(int orderDetailsID) => Context.Order_OrdersDetails.FirstOrDefault(o => o.Purchese_ID == orderDetailsID);


        //get details for orders form specific store by store id
        public IEnumerable<Order_OrdersDetails> GetStoreOrders(int _storeId) => Context.Order_OrdersDetails.Where(od => od.StoreID == _storeId);


        //get order details for an item
        public IEnumerable<Order_OrdersDetails> GetOrderDetailsForItem(int _ItemId) => Context.Order_OrdersDetails.Where(od => od.ItemID == _ItemId);


        //get item quantity record by item id & store id
        ItemQuantity SearchItemQuantity(int? itemID, int? storeID)
        {
            ItemQuantity itemQuantityRecord = Context.ItemQuantities.FirstOrDefault(i => i.ItemID == itemID && i.StoreID == storeID);
            if (itemQuantityRecord != null)
            {
                return itemQuantityRecord;
            }
            return null;
        }


        //create ItemQuantityId column for the new item quantity record 
        int CreateItemId()
        {
            int largestId = 1;
            foreach (var item in Context.ItemQuantities)
            {
                if (item.ItemQuantityID > largestId)
                    largestId = item.ItemQuantityID;
            }
            return largestId + 1;
        }
        ItemQuantity CreateNewItemQuantityRecord(int? itemID, int? storeID)
        {
            ItemQuantity newItemQuantityRecord = new ItemQuantity()
            {
                ItemQuantityID = CreateItemId(),
                ItemID = itemID,
                StoreID = storeID,
                CurrentBalance = 0,
                OpeningBalance = 0,
                BeginningInventory = 0,
                BeginningInventoryPrice = 0
            };
            Context.ItemQuantities.Add(newItemQuantityRecord);
            SaveDBChanges();
            return newItemQuantityRecord;
        }

        void DecreaseItemQuantityBalance(ItemQuantity existedItemQuantityRecord, int? itemID, int? storeID, decimal? quantity)
        {
            if (existedItemQuantityRecord != null)
                existedItemQuantityRecord.CurrentBalance -= quantity;
            else
            {
                ItemQuantity newItemQuantityRecord = CreateNewItemQuantityRecord(itemID, storeID);
                newItemQuantityRecord.CurrentBalance -= quantity;
                SaveDBChanges();
            }
        }

        // create new order details -- 
        public bool CreateNewOrderDetails(Order_OrdersDetails newOrderDetails)
        {
            if (newOrderDetails != null)
            {
                if (searchOrder(newOrderDetails.Purchese_ID) != null)
                {
                    ItemQuantity itemQuantity = SearchItemQuantity(newOrderDetails.ItemID, newOrderDetails.StoreID);
                    if (itemQuantity != null)
                    {
                        DecreaseItemQuantityBalance(itemQuantity, newOrderDetails.ItemID, newOrderDetails.StoreID, newOrderDetails.Quantity);
                    }
                    else
                    {
                        ItemQuantity newItemQuantityRecord = CreateNewItemQuantityRecord(newOrderDetails.ItemID, newOrderDetails.StoreID);
                        DecreaseItemQuantityBalance(newItemQuantityRecord, newOrderDetails.ItemID, newOrderDetails.StoreID, newOrderDetails.Quantity);
                    }
                    
                }
                else
                {
                    int id;
                    if (newOrderDetails.Purchese_ID.HasValue)
                    {
                        id = newOrderDetails.Purchese_ID.Value;
                        Order_Orders newOrder = new Order_Orders()
                        {
                            ID = id,
                            CashBank = 0,
                            CashMoney = 0,
                            CostOrder = 0,
                            IsWaiting = false,
                            Net = 0,
                            TotalPrices = 0,
                        };
                    
                    if (CreateNewOrder(newOrder))
                    {
                        Context.Order_Orders.Add(newOrder);
                        SaveDBChanges();
                        ItemQuantity itemQuantity = SearchItemQuantity(newOrderDetails.ItemID, newOrderDetails.StoreID);
                        if (itemQuantity != null)
                        {
                            DecreaseItemQuantityBalance(itemQuantity, newOrderDetails.ItemID, newOrderDetails.StoreID, newOrderDetails.Quantity);
                        }
                        else
                        {
                            ItemQuantity newItemQuantityRecord = CreateNewItemQuantityRecord(newOrderDetails.ItemID, newOrderDetails.StoreID);
                            DecreaseItemQuantityBalance(newItemQuantityRecord, newOrderDetails.ItemID, newOrderDetails.StoreID, newOrderDetails.Quantity);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                }
                Context.Order_OrdersDetails.Add(newOrderDetails);
                SaveDBChanges();
                return true;

            }
            return false;
        }


        // delete  all order details for specific order by order id
        void DeleteAllOrderDetailsRecordForSpecificOrder(int orderID)
        {
            if (searchOrder(orderID) != null)
            {
                if(GetOrderDetails(orderID).Count() !=0)
                {
                    foreach (var record in GetOrderDetails(orderID))
                    {
                        DeleteOrderDetailsRecord(record.SN);
                    }
                    SaveDBChanges();
                }
                
            }
        }


        // delete order details by order details id
        public bool DeleteOrderDetailsRecord(int orderDetailsID)
        {
            Order_OrdersDetails deletedOrdersDetailsRecord = SearchOrderDetailsRecord(orderDetailsID);
            if (deletedOrdersDetailsRecord != null)
            {
                Context.Order_OrdersDetails.Remove(deletedOrdersDetailsRecord);
                //Context.Entry(deletedOrdersDetailsRecord).State = EntityState.Deleted;
                SaveDBChanges();
                return true;
            }
            return false;
        }
    }
}