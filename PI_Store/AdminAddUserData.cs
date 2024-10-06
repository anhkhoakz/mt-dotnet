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
        private readonly string _connectionString = "Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg";
        public string Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }   
        public string Status { get; set; }
        public string Pasword { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string HireDate { get; set; }
        public string Salary { get; set; }

        public List<AdminAddUserData> UserListData()
        {
            List<AdminAddUserData> userListData = new List<AdminAddUserData>();

            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(_connectionString))
                    {
                        connection.Open();
                        string query = "SELECT * FROM Employee";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                AdminAddUserData userData = new AdminAddUserData();
                                userData.Id = (string)reader["ID"].ToString();
                                userData.Name = (string)reader["Name"].ToString();
                                userData.Role = (string)reader["Role"].ToString();
                                userData.Phone = (string)reader["Phone"].ToString();
                                userData.Status = (string)reader["Status"].ToString();
                                userData.Pasword = (string)reader["Password"].ToString();
                                userData.Email = (string)reader["Email"].ToString();
                                userData.Address = (string)reader["Address"].ToString();
                                userData.HireDate = (string)reader["HireDate"].ToString();
                                userData.Salary = (string)reader["Salary"].ToString();

                                userListData.Add(userData);
                            }
                        }
                    }
                    
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Connection Failed " + exception);
                }
                return userListData;
            }
            
        }
    }
}
