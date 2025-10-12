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
    public partial class CarrierInfo : Form
    {
        public CarrierInfo()
        {
            InitializeComponent();
        }
        private void ResetCommand()
        {

            txtID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            dtpDob.Value = DateTime.Now;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtContact.Text = "";
            txtAddress.Text = "";
        }

        private void CarrierInfo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdate;
            this.ResetCommand();

            string userQuery = $"SELECT UserId FROM LOGIN WHERE Email='{staticWelcome.email}'";
            var idResult = Dbhelper.GetQueryData(userQuery);

                int Id = Convert.ToInt32(idResult.Data.Rows[0]["UserId"]);

            try
            {
                string query = "SELECT * FROM Carrier WHERE LoginId=" + Id;
                var resultS = Dbhelper.GetQueryData(query);

                if (resultS.HasError)
                {
                    MessageBox.Show(resultS.Message);
                    return;
                }


                txtID.Text = resultS.Data.Rows[0]["CarrierId"].ToString();
                txtName.Text = resultS.Data.Rows[0]["Name"].ToString();
                txtEmail.Text = resultS.Data.Rows[0]["Email"].ToString();
                txtPassword.Text = resultS.Data.Rows[0]["Password"].ToString();
                dtpDob.Value = Convert.ToDateTime(resultS.Data.Rows[0]["DateOfBirth"]);
                rdbMale.Checked = resultS.Data.Rows[0][6].ToString().ToUpper() == "Male".ToUpper();
                rdbFemale.Checked = resultS.Data.Rows[0][6].ToString().ToUpper() == "Female".ToUpper();
                txtContact.Text = resultS.Data.Rows[0]["Contact"].ToString();
                txtAddress.Text = resultS.Data.Rows[0]["Address"].ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading carrier info: " + ex.Message);
                return;
            }


           

        }
        private bool CheckEmail(string email = "")
        {
            string checkEmail = $"SELECT * FROM Signup WHERE Email = '{email}'";
            Result checkResult = Dbhelper.GetQueryData(checkEmail);

            if (!checkResult.HasError && checkResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("This email is already registered. Please use a different email.");
                return true;
            }

            string checkEmail1 = $"SELECT * FROM LOGIN WHERE Email = '{email}'";
            Result checkResult1 = Dbhelper.GetQueryData(checkEmail1);

            if (!checkResult1.HasError && checkResult1.Data.Rows.Count > 0)
            {
                MessageBox.Show("This email is already registered. Please use a different email.");
                return true;
            }

            return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userQuery = $"SELECT UserId FROM LOGIN WHERE Email='{staticWelcome.email}'";
            var idResult = Dbhelper.GetQueryData(userQuery);



            int Id = Convert.ToInt32(idResult.Data.Rows[0]["UserId"]);

            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            DateTime dob = dtpDob.Value;
            string gender = rdbMale.Checked ? rdbMale.Text : rdbFemale.Checked ? rdbFemale.Text : "";
            string contact = txtContact.Text;
            string address = txtAddress.Text;
            if (dob > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("invalid please add valid Date of Birth");
                return;
            }

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
                MessageBox.Show("Invalid Number");
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
                    MessageBox.Show("Invalid Number");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Number");
                return;
            }


            string query = $"UPDATE Carrier SET Name='{name}', Password='{password}', DateOfBirth='{dob:yyyy-MM-dd}', Gender='{gender}', Contact='{contact}', Address='{address}' WHERE LoginId = {Id}";
            string query1 = $"UPDATE LOGIN SET Name='{name}', Password='{password}'WHERE UserId = {Id}";
            var r = Dbhelper.ExecuteNonresultquery(query);
            var q = Dbhelper.ExecuteNonresultquery(query1);
            if (r.HasError)
            {
                MessageBox.Show("Error updating profile: " + r.Message);
                return;
            }
            if (q.HasError)
            {
                MessageBox.Show("Error updating profile: " + q.Message);
                return;
            }

            MessageBox.Show("Profile updated successfully!");
            
        }

        private void CarrierInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ResetCommand();
        }
    }
}
