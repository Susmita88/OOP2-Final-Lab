using Project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ElectronicItemController
    {
        static Database db = new Database();
        public static bool AddElectronicItem(dynamic item)
        {
            ElectronicItem i = new ElectronicItem();
            i.ItemName = item.ItemName;
            i.ItemPrice = item.ItemPrice;
            i.Quantity = item.Quantity;

            return db.ElectronicsItems.AddElectronicItem(i);
        }

        public static ElectronicItem GetElectronicItem(string itemname)
        {
            return db.ElectronicsItems.GetElectronicItem(itemname);
        }

        public static bool UpdateElectronicItem(dynamic item)
        {
            ElectronicItem i = new ElectronicItem();
            i.ItemName = item.ItemName;
            i.ItemPrice = item.ItemPrice;
            return db.ElectronicsItems.UpdateElectronicItem(i);
        }

        public static bool DeleteElectronicItem(string itemname)
        {
            return db.ElectronicsItems.DeleteElectronicItem(itemname);
        }

        public static ArrayList GetAllElectronicsItems()
        {
            return db.ElectronicsItems.GetAllElectronicsItems();
        }
    }
}
