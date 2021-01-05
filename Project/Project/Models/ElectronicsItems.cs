using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class ElectronicsItems
    {
        SqlConnection conn;
        public ElectronicsItems(SqlConnection conn)
        {
            this.conn = conn;
        }

        public bool AddElectronicItem(ElectronicItem item)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Users VALUES ('{0}','{1}','{2}')", item.ItemName,item.ItemName,item.Quantity);
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            return true;
            return false;
        }

        public ArrayList GetAllElectronicsItems()
        {
            ArrayList items = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM ElectronicsItems";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ElectronicItem item = new ElectronicItem();
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
                item.ItemPrice = reader.GetInt32(reader.GetOrdinal("ItemPrice"));
                item.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));


                items.Add(item);
            }
            conn.Close();
            return items;
        }

        public ElectronicItem GetElectronicItem(string itemname)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}'", itemname);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            ElectronicItem item = null;
            while (reader.Read())
            {
                item = new ElectronicItem();
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
                item.ItemPrice = reader.GetInt32(reader.GetOrdinal("ItemPrice"));
                
            }
            conn.Close();
            return item;
        }

        public bool UpdateElectronicItem(ElectronicItem item)
        {
            conn.Open();
            string query = String.Format("UPDATE ElectronicsItems SET ItemName='{0}' WHERE ItemPrice='{1}'", item.ItemName, item.ItemPrice);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) 
                return true;
            return false;
        }

        public bool DeleteElectronicItem(string itemname)
        {
            conn.Open();
            string query = String.Format("DELETE FROM ElectronicsItems WHERE ItemName='{0}'", itemname);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

    }
}
