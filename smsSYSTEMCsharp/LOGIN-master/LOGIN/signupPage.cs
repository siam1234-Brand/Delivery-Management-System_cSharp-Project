using System;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LOGIN
{
    public partial class signupPage : Form
    {
        public signupPage()
        {
            InitializeComponent();
        }

        private void signupPage_Load(object sender, EventArgs e)
        {
               
            if (this.Owner != null)
            {
                this.Owner.Hide();
            }
        }

        private void signupPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }


        }
        private bool CheckEmail(string email = "")
        {
            

            string checkEmail = $"SELECT * FROM Signup WHERE Email = '{email}'";
            Result checkResult = Dbhelper.GetQueryData(checkEmail);

            if (!checkResult.HasError && checkResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("Email already in use. Please use a different email.");
                return true;
            }

            string checkEmail1 = $"SELECT * FROM LOGIN WHERE Email = '{email}'";
            Result checkResult1 = Dbhelper.GetQueryData(checkEmail1);

            if (!checkResult1.HasError && checkResult1.Data.Rows.Count > 0)
            {
                MessageBox.Show("Email already in use. Please use a different email.");
                return true;
            }

       
        
            return false;
        }

        private bool assignEmail(string Email = "")
        {

            string passwordQuery = $"SELECT Password FROM Signup WHERE Email = '{Email}'";
            Result checkResult2 = Dbhelper.GetQueryData(passwordQuery);

            if (!checkResult2.HasError && checkResult2.Data.Rows.Count > 0)
            {
                var passwordValue = checkResult2.Data.Rows[0]["Password"];

                if (passwordValue == DBNull.Value || string.IsNullOrEmpty(passwordValue.ToString()))
                {
                    return true;
                }
               
            }
            return false;   
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            string email = txtEmail2.Text;
            string password = txtPassword2.Text;
            DateTime dob = dtpDob.Value;
            string gender = rdbMale.Checked ? "Male" : rdbFemale.Checked ? "Female" : "";
            string contact = txtContact.Text;
            string address = txtAddress.Text;

            if (contact.StartsWith("+880"))
            {
                contact = contact.Substring(3);
            }

            else if (contact.StartsWith("880"))
            {
                contact = contact.Substring(2);
            }

            if (!contact.All(char.IsDigit))
            {
                MessageBox.Show("Invalid number");
                return;
            }

        
            if (contact.Length == 11 && contact.StartsWith("01"))
            {
                char thirdDigit = contact[2];
                if (thirdDigit >= '3' && thirdDigit <= '9')
                {
                    // Valid mobile number
                }
                else
                {
                    MessageBox.Show("Enter a valid number.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid number");
                return;
            }


            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please add your name.");
                return;

            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                MessageBox.Show("Please add a valid email");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 4)
            {
                MessageBox.Show("Please add a valid password (atleast 4 character.)");
                return;
            }

            if (dob > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Please add a valid date of birth.");
                return;
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Please select a gender.");

                return;

            }
            string UpdateSignup;
            if (assignEmail(email))
            {
                string Query2 = $"SELECT ClientId FROM SignUp WHERE Email='{email}'";
                var idResult = Dbhelper.GetQueryData(Query2);
                if (idResult.HasError)
                {
                    MessageBox.Show(idResult.Message);
                    return;
                }
                int ClientId = Convert.ToInt32(idResult.Data.Rows[0]["ClientId"]);

                UpdateSignup = "UPDATE SignUp SET " + "Password = '" + password + "', " + "DateOfBirth = '" + dob + "', " + "Gender = '" + gender + "', " + "ClientContact = '" + contact + "', " + "Address = '" + address + "' " + "WHERE ClientId = " + ClientId;
                Result signupResult1 = Dbhelper.ExecuteNonresultquery(UpdateSignup);
               
                if (signupResult1.HasError) { MessageBox.Show("Error creating profile: " + signupResult1.Message); return; }

                MessageBox.Show("Account Update successfully! You can now login as " + email);
                this.Hide();
                if (this.Owner != null)
                {
                    this.Owner.Show();
                }
                return;

            }

            if (CheckEmail(email))
            { 
                return;
            }

            UpdateSignup = $"INSERT INTO SignUp (Name, Email, Password,DateOfBirth,Gender,ClientContact,Address, Role) " 
            + $"VALUES ('{name}', '{email}', '{password}', '{dob:yyyy-MM-dd}', '{gender}' , '{contact}', '{address}','Client')";
            
            Result signupResult = Dbhelper.ExecuteNonresultquery(UpdateSignup);

            if (signupResult.HasError) { MessageBox.Show("Error creating profile: " + signupResult.Message); return; }

            MessageBox.Show("Account created successfully! You can now login as " + email);
            this.Hide();
            if (this.Owner != null)
            {
                this.Owner.Show();
            }


        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword2.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContact.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCreate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

    }

}