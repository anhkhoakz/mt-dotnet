using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PI_Store
{
    public partial class AdminAddProduct : UserControl
    {
        private const string ConnectionString = "Data Source='192.168.0.101, 1433';Initial Catalog=PI_STORE;Persist Security Info=True;User ID=SA;Password=Gv.BTqpg2mC6qCa8uikg";

        public AdminAddProduct()
        {
            InitializeComponent();
        }

        public bool isEmptyField()
        {

            if (string.IsNullOrEmpty(AdminAddProduct_IDTextBox.Text) || string.IsNullOrEmpty(AdminAddProduct_NameTextBox.Text) || string.IsNullOrEmpty(AdminAddProduct_TypeComboBox.Text) || string.IsNullOrEmpty(AdminAddProduct_StockTextBox.Text) || string.IsNullOrEmpty(AdminAddProduct_PriceTextBox.Text) || string.IsNullOrEmpty(AdminAddProduct_StatusComboBox.Text))
            {
                return true;
            }
            return false;
        }

        private void AdminAddProduct_AddButton_Click(object sender, EventArgs e)
        {
            if (isEmptyField())
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Product WHERE ID = @ID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", AdminAddProduct_IDTextBox.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Product ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string path = Path.Combine(Directory.GetCurrentDirectory(), "Product_Directory\\");
                    path += AdminAddProduct_IDTextBox.Text.Trim() + ".jpg";

                    string DirectoryPath = Path.GetDirectoryName(path);

                    if (!Directory.Exists(DirectoryPath))
                    {
                        Directory.CreateDirectory(DirectoryPath);
                    }

                    File.Copy(adminAddProductImageView.ImageLocation, path, true);

                    query = "INSERT INTO Product (ID, Name, Type, Stock, Price, Status, Image, AddedDate) VALUES (@ID, @Name, @Type, @Stock, @Price, @Status, @Image, @AddedDate)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", AdminAddProduct_IDTextBox.Text);
                        cmd.Parameters.AddWithValue("@Name", AdminAddProduct_NameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Type", AdminAddProduct_TypeComboBox.Text);
                        cmd.Parameters.AddWithValue("@Stock", AdminAddProduct_StockTextBox.Text);
                        cmd.Parameters.AddWithValue("@Price", AdminAddProduct_PriceTextBox.Text);
                        cmd.Parameters.AddWithValue("@Status", AdminAddProduct_StatusComboBox.Text);
                        cmd.Parameters.AddWithValue("@Image", path);
                        cmd.Parameters.AddWithValue("@AddedDate", DateTime.Today);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AdminAddProduct_ImportButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";
                string imageLocation = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    adminAddProductImageView.ImageLocation = imageLocation;
                }

            } catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
