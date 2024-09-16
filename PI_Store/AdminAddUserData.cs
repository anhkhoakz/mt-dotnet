using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PI_Store
{
    class AdminAddUserData
    {
        private readonly string connectionString = "Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg";
        public string ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateRegistered { get; set; }

        public List<AdminAddUserData> UserListData()
        {
            List<AdminAddUserData> UserListData = new List<AdminAddUserData>();

            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Employee";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                AdminAddUserData userData = new AdminAddUserData();
                                userData.ID = (string)reader["ID"].ToString();
                                userData.Password = (string)reader["Password"].ToString();
                                // TODO: Add data from database

                                UserListData.Add(userData);
                            }
                        }
                    }
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Connection Failed " + exception);
                }
                return UserListData;
            }
            
        }
    }
}
