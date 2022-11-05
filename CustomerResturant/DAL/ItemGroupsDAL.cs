using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomerResturant.DAL
{
    public class ItemGroupsDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        void SaveDBChanges()
        {
            Context.SaveChanges();
        }

        public IEnumerable<Item_Groups> GetAllItemsCategoriess() => Context.Item_Groups.ToList();

        public Item_Groups SearchSpecificItemCategory(int itemGroupID) => Context.Item_Groups.Find(itemGroupID);

        // get items by item category ID 
        public IEnumerable<Item_Items> GetItemsByCategoryID(int itemCategoryID) => Context.Item_Items.Where(i => i.Category_ID == itemCategoryID).ToList();

        public bool CreateNewItemCategory(Item_Groups newItemCategory)
        {
            if (newItemCategory != null && SearchSpecificItemCategory(newItemCategory.ID) == null)
            {
                Context.Item_Groups.Add(newItemCategory);
                SaveDBChanges();
                return true;
            }
            return false;
        }

        public bool DeleteExistedItemCategory(int CategoryID)
        {
            if (SearchSpecificItemCategory(CategoryID) != null)
            {
                Context.Item_Groups.Remove(SearchSpecificItemCategory(CategoryID));
                SaveDBChanges();
                return true;
            }
            return false;
        }

        public bool EditExistedItemCategory(int CategotyID , Item_Groups updatedItemCategory)
        {
            Item_Groups modifiedCategory = SearchSpecificItemCategory(CategotyID);

            if (modifiedCategory != null)
            {
                //CopyProperties(modifiedCategory, updatedItemCategory);

                modifiedCategory.Name = updatedItemCategory.Name;
                modifiedCategory.Printer = updatedItemCategory.Printer;
                modifiedCategory.IsShow = updatedItemCategory.IsShow;
                modifiedCategory.Image = updatedItemCategory.Image;
                modifiedCategory.UserID_Add = updatedItemCategory.UserID_Add;
                modifiedCategory.UserBranch_Add = updatedItemCategory.UserBranch_Add;
                modifiedCategory.UserMacAddress_Add = updatedItemCategory.UserMacAddress_Add;
                modifiedCategory.UserDate_Add = updatedItemCategory.UserDate_Add;
                modifiedCategory.UserID_Update = updatedItemCategory.UserID_Update;
                modifiedCategory.UserBranch_Update = updatedItemCategory.UserBranch_Update;
                modifiedCategory.UserMacAddress_Update = updatedItemCategory.UserMacAddress_Update;
                modifiedCategory.UserDate_Update = updatedItemCategory.UserDate_Update;
                SaveDBChanges();
                return true;
            }
            return false;
        }


        

        // copy properties values from object to object 
        void CopyProperties(object objSource, object objDestination)
        {
            //get the list of all properties in the destination object
            var destProps = objDestination.GetType().GetProperties();

            //get the list of all properties in the source object
            foreach (var sourceProp in objSource.GetType().GetProperties())
            {
                foreach (var destProperty in destProps)
                {
                    //if we find match between source & destination properties name, set
                    //the value to the destination property
                    if (destProperty.Name == sourceProp.Name &&
                            destProperty.PropertyType.IsAssignableFrom(sourceProp.PropertyType))
                    {
                        destProperty.SetValue(destProps, sourceProp.GetValue(
                            sourceProp, new object[] { }), new object[] { });
                        break;
                    }
                }
            }
        }


    }
}