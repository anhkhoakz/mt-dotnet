using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PI_Store
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private readonly string connectionString = "Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (EmptyFields())
            {
                MessageBox.Show("All fields are required to log in", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = userNametextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            try {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee WHERE ID = @id AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                userNametextBox.Clear();
                                passwordTextBox.Clear();

                                MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                AdminMainForm adminForm = new AdminMainForm();
                                adminForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid credential", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                userNametextBox.Clear();
                                passwordTextBox.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Connection failed" + exception, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        public bool EmptyFields()
        {
            return string.IsNullOrWhiteSpace(userNametextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text);
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }
    }
}
