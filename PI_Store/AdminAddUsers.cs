using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PI_Store
{
    public partial class AdminAddUsers : UserControl
    {
        public AdminAddUsers()
        {
            InitializeComponent();
            
            DisplayAddUsersData();
        }

        private const string ConnectionString = "Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg";

        public void DisplayAddUsersData()
        {
            AdminAddUserData userData = new AdminAddUserData();
            List<AdminAddUserData> listData = userData.UserListData();

            DataUsersDataGridView.DataSource = listData;
        }

        private void AdminAddUsers_Load(object sender, EventArgs e)
        {

        }

        private bool IsEmptyField()
        {
            return string.IsNullOrWhiteSpace(AdminAddUser_IDTextBox.Text) ||
                string.IsNullOrWhiteSpace(AdminAddUser_PasswordTextBox.Text) ||
                string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(PhoneLabel.Text) ||
                string.IsNullOrWhiteSpace(AddressLabel.Text) ||
                string.IsNullOrWhiteSpace(SalaryLabel.Text) ||
                string.IsNullOrWhiteSpace(HireDateLabel.Text) ||
                string.IsNullOrWhiteSpace(AdminAddUser_RoleComboBox.Text) ||
                string.IsNullOrWhiteSpace(AdminAddUser_StatusComboBox.Text);
        }

        private void AdminAddUser_AddButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show(@"All fields must be filled", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userId = AdminAddUser_IDTextBox.Text.Trim();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Employee WHERE ID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count >= 1)
                            {
                                MessageBox.Show(@"User ID already exists", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string password = AdminAddUser_PasswordTextBox.Text.Trim();
                            string role = AdminAddUser_RoleComboBox.Text.Trim();
                            string status = AdminAddUser_StatusComboBox.Text.Trim();
                            string name = NameTextBox.Text.Trim();
                            string email = EmailTextBox.Text.Trim();
                            string phone = PhoneTextBox.Text.Trim();
                            string address = AddressTextBox.Text.Trim();
                            decimal salary = decimal.Parse(SalaryTextBox.Text.Trim());
                            DateTime hireDate = DateTime.Parse(HireDateTimePicker.Text.Trim());

                            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
                            {
                                MessageBox.Show(@"Invalid email format", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (role != "Admin" && role != "Cashier")
                            {
                                MessageBox.Show(@"Role must be either 'admin' or 'cashier'", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                            {
                                MessageBox.Show(@"Name cannot contain special characters or numbers", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                            {
                                MessageBox.Show(@"Phone number must contain digits only", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!decimal.TryParse(SalaryTextBox.Text.Trim(), out salary))
                            {
                                MessageBox.Show(@"Invalid salary format. Please enter a valid decimal number.", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            if (!DateTime.TryParse(HireDateTimePicker.Text.Trim(), out hireDate))
                            {
                                MessageBox.Show(@"Invalid hire date format. Please enter a valid date.", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            query = "INSERT INTO Employee (ID, Password, Role, Status, Name, Email, Phone, Address, Salary, HireDate) VALUES (@id, @password, @role, @status, @name, @email, @phone, @address, @salary, @hireDate)";
                            using (SqlCommand insertCommand = new SqlCommand(query, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@id", userId);
                                insertCommand.Parameters.AddWithValue("@password", password);
                                insertCommand.Parameters.AddWithValue("@role", role);
                                insertCommand.Parameters.AddWithValue("@status", status);
                                insertCommand.Parameters.AddWithValue("@name", name);
                                insertCommand.Parameters.AddWithValue("@email", email);
                                insertCommand.Parameters.AddWithValue("@phone", phone);
                                insertCommand.Parameters.AddWithValue("@address", address);
                                insertCommand.Parameters.AddWithValue("@salary", salary);
                                insertCommand.Parameters.AddWithValue("@hireDate", hireDate);

                                insertCommand.ExecuteNonQuery();
                                MessageBox.Show(@"User added successfully", @"Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                DisplayAddUsersData();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection failed" + exception, @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataUsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataUsersDataGridView.Rows[e.RowIndex];

                AdminAddUser_IDTextBox.Text = row.Cells[0].Value?.ToString() ?? "";
                AdminAddUser_PasswordTextBox.Text = row.Cells[5].Value?.ToString() ?? "";
                AdminAddUser_RoleComboBox.Text = row.Cells[2].Value?.ToString() ?? "";
                AdminAddUser_StatusComboBox.Text = row.Cells[4].Value?.ToString() ?? "";
                NameTextBox.Text = row.Cells[1].Value?.ToString() ?? "";
                EmailTextBox.Text = row.Cells[6].Value?.ToString() ?? "";
                PhoneTextBox.Text = row.Cells[3].Value?.ToString() ?? "";
                AddressTextBox.Text = row.Cells[7].Value?.ToString() ?? "";
                SalaryTextBox.Text = row.Cells[9].Value?.ToString() ?? "";
                HireDateTimePicker.Text = row.Cells[8].Value?.ToString() ?? "";
            }
        }

        private void AdminAddUser_UpdateButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show(@"All fields must be filled", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string userId = AdminAddUser_IDTextBox.Text.Trim();
                    string password = AdminAddUser_PasswordTextBox.Text.Trim();
                    string role = AdminAddUser_RoleComboBox.Text.Trim();
                    string status = AdminAddUser_StatusComboBox.Text.Trim();
                    string name = NameTextBox.Text.Trim();
                    string email = EmailTextBox.Text.Trim();
                    string phone = PhoneTextBox.Text.Trim();
                    string address = AddressTextBox.Text.Trim();
                    decimal salary = decimal.Parse(SalaryTextBox.Text.Trim());
                    DateTime hireDate = DateTime.Parse(HireDateTimePicker.Text.Trim());

                    if (!System.Text.RegularExpressions.Regex.IsMatch(email,
                            @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"))
                    {
                        MessageBox.Show(@"Invalid email format", @"Error Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    if (role != "Admin" && role != "Cashier")
                    {
                        MessageBox.Show(@"Role must be either 'admin' or 'cashier'", @"Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show(@"Name cannot contain special characters or numbers", @"Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                    {
                        MessageBox.Show(@"Phone number must contain digits only", @"Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(SalaryTextBox.Text.Trim(), out salary))
                    {
                        MessageBox.Show(@"Invalid salary format. Please enter a valid decimal number.",
                            @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!DateTime.TryParse(HireDateTimePicker.Text.Trim(), out hireDate))
                    {
                        MessageBox.Show(@"Invalid hire date format. Please enter a valid date.", @"Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query =
                        "UPDATE Employee SET Password = @password, Role = @role, Status = @status, Name = @name, Email = @email, Phone = @phone, Address = @address, Salary = @salary, HireDate = @hireDate WHERE ID = @id";

                    using (SqlCommand updateCommand = new SqlCommand(query, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@id", userId.Trim());
                        updateCommand.Parameters.AddWithValue("@password", password.Trim());
                        updateCommand.Parameters.AddWithValue("@role", role.Trim());
                        updateCommand.Parameters.AddWithValue("@status", status.Trim());
                        updateCommand.Parameters.AddWithValue("@name", name.Trim());
                        updateCommand.Parameters.AddWithValue("@email", email.Trim());
                        updateCommand.Parameters.AddWithValue("@phone", phone.Trim());
                        updateCommand.Parameters.AddWithValue("@address", address.Trim());
                        updateCommand.Parameters.AddWithValue("@salary", salary);
                        updateCommand.Parameters.AddWithValue("@hireDate", hireDate);

                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show(@"User updated successfully", @"Success Message", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        DisplayAddUsersData();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection failed" + exception, @"Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void clearFields()
        {
            AdminAddUser_IDTextBox.Text = "";
            AdminAddUser_PasswordTextBox.Text = "";
            AdminAddUser_RoleComboBox.Text = "";
            AdminAddUser_StatusComboBox.Text = "";
            NameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            AddressTextBox.Text = "";
            SalaryTextBox.Text = "";
            HireDateTimePicker.Text = "";
        }

        private void AdminAddUser_ClearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AdminAddUser_DeleteButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyField())
            {
                MessageBox.Show(@"All fields must be filled", @"Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string userId = AdminAddUser_IDTextBox.Text.Trim();

                    string query = "SELECT * FROM Employee WHERE ID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show(@"User ID does not exist", @"Error Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                return;
                            }

                            query = "DELETE FROM Employee WHERE ID = @id";
                            using (SqlCommand deleteCommand = new SqlCommand(query, connection))
                            {
                                deleteCommand.Parameters.AddWithValue("@id", userId);
                                deleteCommand.ExecuteNonQuery();
                                MessageBox.Show(@"User deleted successfully", @"Success Message", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                DisplayAddUsersData();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection failed" + exception, @"Error Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
