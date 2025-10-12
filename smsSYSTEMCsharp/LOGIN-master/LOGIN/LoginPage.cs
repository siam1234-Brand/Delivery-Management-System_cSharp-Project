using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string role = "";
            string email = txtEmail.Text.Trim();
            string password = txtPass.Text.Trim();


            var query = $"SELECT Role, Name FROM Signup WHERE Email = '{email}' AND Password = '{password}'";
            var result = Dbhelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return;
            }

            if (result.Data.Rows.Count == 1)
            {
                role = result.Data.Rows[0]["Role"].ToString();
                staticWelcome.name = result.Data.Rows[0]["Name"].ToString();
                staticWelcome.email = email;
            }
            else
            {
                var query1 = $"SELECT Role, Name FROM LOGIN WHERE Email = '{email}' AND Password = '{password}'";
                var result1 = Dbhelper.GetQueryData(query1);

                if (result1.HasError)
                {
                    MessageBox.Show(result1.Message);
                    return;
                }

                if (result1.Data.Rows.Count == 1)
                {
                    role = result1.Data.Rows[0]["Role"].ToString();
                    staticWelcome.name = result1.Data.Rows[0]["Name"].ToString();
                    staticWelcome.email = email;
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtPass.Focus();
                    return;
                }
            }

            if (role == "Admin")
                new admin().Show(this);
            else if (role == "Employee")
                new Employee().Show(this);
            else if (role == "Client")
                new clientPage().Show(this);
            else if (role == "Carrier")
                new carrierPage().Show(this);
            else
                MessageBox.Show("Invalid User");
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            signupPage signupPage = new signupPage();
            signupPage.Show(this);

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}