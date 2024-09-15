using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PI_Store
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to log in", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            String username, password;
            username = userNametextBox.Text;
            password = passwordTextBox.Text;

            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    String query = "SELECT * FROM Employee WHERE ID = @id AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", userNametextBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", passwordTextBox.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            userNametextBox.Clear();
                            passwordTextBox.Clear();

                            // MenuForm
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

                catch (Exception exception)
                {
                    MessageBox.Show("Connection failed" + exception, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheckBox.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (userNametextBox.Text == "" || passwordTextBox.Text == "")
            {
                return true;
            }
            return false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                loginButton.PerformClick();
            }
        }
    }
}
