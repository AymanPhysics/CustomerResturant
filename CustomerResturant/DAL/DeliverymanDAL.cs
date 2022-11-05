using CustomerResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerResturant.DAL
{
    public class DeliverymanDAL
    {
        CustomerResturantDB Context = new CustomerResturantDB();

        void SaveDBChanges()
        {
            Context.SaveChanges();
        }

        public Restaurant_DeliveryMan SearchDeliveryman(int deliverymanID) => Context.Restaurant_DeliveryMan.Find(deliverymanID);

        public IEnumerable<Restaurant_DeliveryMan> GetAllDeliverymen() => Context.Restaurant_DeliveryMan.ToList();

        public IEnumerable<Restaurant_DeliveryMan> GetAllDeliverymenByBranchID(int branchID) => Context.Restaurant_DeliveryMan.Where(d => d.BranchID == branchID);

        public bool CreateNewDeliveryman(Restaurant_DeliveryMan newDeliveryman)
        {
            if (newDeliveryman !=null && SearchDeliveryman(newDeliveryman.SN) == null)
            {
                Context.Restaurant_DeliveryMan.Add(newDeliveryman);
                SaveDBChanges();
                return true;
            }
            return false;
        }

        public bool DeleteDeliveryman(int deliverymanID)
        {
            if (SearchDeliveryman(deliverymanID) !=null)
            {
                Context.Restaurant_DeliveryMan.Remove(SearchDeliveryman(deliverymanID));
                SaveDBChanges();
                return true;
            }
            return false;
        }

        public bool EditDeliveryman(int deliverymanID , Restaurant_DeliveryMan updatedDeliveryman)
        {
            Restaurant_DeliveryMan modifiedDeliveryman = SearchDeliveryman(deliverymanID);
            if (modifiedDeliveryman != null && updatedDeliveryman != null)
            {
                modifiedDeliveryman.DeliveryName = updatedDeliveryman.DeliveryName;
                modifiedDeliveryman.BranchID = updatedDeliveryman.BranchID;
                modifiedDeliveryman.UserID_Add = updatedDeliveryman.UserID_Add;
                modifiedDeliveryman.UserBranch_Add = updatedDeliveryman.UserBranch_Add;
                modifiedDeliveryman.UserMacAddress_Add = updatedDeliveryman.UserMacAddress_Add;
                modifiedDeliveryman.UserDate_Add = updatedDeliveryman.UserDate_Add;
                modifiedDeliveryman.UserID_Update = updatedDeliveryman.UserID_Update;
                modifiedDeliveryman.UserBranch_Update = updatedDeliveryman.UserBranch_Update;
                modifiedDeliveryman.UserMacAddress_Update = updatedDeliveryman.UserMacAddress_Update;
                modifiedDeliveryman.UserDate_Update = updatedDeliveryman.UserDate_Update;
                SaveDBChanges();
                return true;
            }
            return false;
        }

        // -------------------------  deliveryman Orders -----------------------------



    }
}