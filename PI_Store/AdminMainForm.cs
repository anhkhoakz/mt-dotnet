using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Store
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();

            loginForm.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e) { }

        private void panel4_Paint(object sender, PaintEventArgs e) { }

        private void adminAddProduct1_Load(object sender, EventArgs e)
        {
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
        }
    }
}
