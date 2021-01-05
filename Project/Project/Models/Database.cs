using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project.Models
{
    class Database
    {
        public Users Users { get; set; }
        public ElectronicsItems ElectronicsItems { get; set; }
        public Database()
        {
            string connString = "Server=USER-PC\SQLEXPRESS; Integrated Security=true;Database=project_6;";
            SqlConnection conn = new SqlConnection(connString);
            Users = new Users(conn);
            ElectronicsItems = new ElectronicsItems(conn);

        }
    }
}
