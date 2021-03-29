using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMAS
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public bool LoginFlag { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            LoginFlag = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAdapter = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable user_DT = userAdapter.GetDataByUserPass(textBoxUsername.Text, textBoxPassword.Text);
            if(user_DT.Rows.Count > 0) {
                //user exist- close the form
                LoginFlag = true;
                UserID = int.Parse(user_DT.Rows[0]["UserID"].ToString());
                UserName = user_DT.Rows[0]["UserName"].ToString();
                Close();
            }
            else 
            {
                //no user exist in the table
                MessageBox.Show("Access Denied!");
                LoginFlag = false;
            }

                
            
        }
    }
}
