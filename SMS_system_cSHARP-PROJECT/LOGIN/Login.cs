using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void btnlogin_Click(object sender, EventArgs e)
        {
            AuthService auth = new AuthService(); 

            DataRow user = auth.Login(txtEmail.Text.Trim(), txtPass.Text.Trim()); 

  
            if (user != null) 

            { 

                staticWelcome.name = user["Name"].ToString(); 
                staticWelcome.email = user["Email"].ToString();

                string role = user["Role"].ToString(); 

  

                if (role == "Admin") 
                    new admin().Show(this); 

                else if (role == "Employee") 
                    new employee().Show(this); 

                else if (role == "Client") 
                    new clientPage().Show(this);

                else if (role == "Carrier")
                    new carrierPage().Show(this);

                else 
                    MessageBox.Show("Unauthorized role."); 

            } 

            else 

            { 
                MessageBox.Show("Invalid login credentials."); 
            } 

        }

        private void btnSignUp_Click(object sender, EventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
