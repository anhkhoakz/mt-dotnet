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
    public partial class AdminAddUsers : UserControl
    {
        public AdminAddUsers()
        {
            InitializeComponent();
            
            DisplayAddUsersData();
        }

        public void DisplayAddUsersData()
        {
            AdminAddUserData userData = new AdminAddUserData();
            List<AdminAddUserData> listData = userData.UserListData();

            DataUsersDataGridView.DataSource = listData;
        }

        private void AdminAddUsers_Load(object sender, EventArgs e)
        {

        }
    }
}
