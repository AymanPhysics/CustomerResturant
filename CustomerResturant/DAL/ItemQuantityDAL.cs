using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace newWorkRes.DAL
{
    public class ItemQuantityDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        //get all item quantities in the store
        public IEnumerable<ItemQuantity> GetAllItems()=> Context.ItemQuantities;


        //check if the item is exist by item id
        public bool ItemIsExist(int _itemId)
        {
            bool exist = false;
            foreach (var item in Context.ItemQuantities)
            {
                if (item.ItemID == _itemId)
                    exist = true;
            }
            return exist;
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

        //add new item(record) which is not exist
        public void AddNewItem(int _itemId, int _storeId)
        {
            ItemQuantity NewItem = new ItemQuantity {ItemQuantityID=CreateItemId(), ItemID = _itemId, StoreID = _storeId, CurrentBalance = 0 , OpeningBalance=0, BeginningInventory=0, BeginningInventoryPrice=0 };
            Context.ItemQuantities.Add(NewItem);
            Context.SaveChanges();
        }

        public bool CreateNewItemQuantity(ItemQuantity newItemQuantity)
        {
            if (newItemQuantity != null)
            {
                newItemQuantity.ItemQuantityID = CreateItemId();
                Context.ItemQuantities.Add(newItemQuantity);
                Context.SaveChanges();
                return true;
            }
            return false;
        }

        //search for the sold item ItemQuantityID by itemId
        public int SearchForItemQuantityId(int _itemId,int _storeId)
        {
            int SoldItemQuantityId=0;
            foreach (var item in Context.ItemQuantities)
            {
                if (item.ItemID == _itemId && item.StoreID == _itemId)
                { SoldItemQuantityId = item.ItemQuantityID; }
            }
            return SoldItemQuantityId;
        }

        //subtract the required quantity from the exist quantity in the store
        public void LoseQuantity(int _itemId,int _storeId,decimal _requiredQuantity)
        {
            int SoldItemQuantityId = SearchForItemQuantityId(_itemId,_storeId);
            ItemQuantity SoldItem = Context.ItemQuantities.Find(SoldItemQuantityId);
            SoldItem.CurrentBalance -= _requiredQuantity;
            Context.SaveChanges();
        }
    }
}