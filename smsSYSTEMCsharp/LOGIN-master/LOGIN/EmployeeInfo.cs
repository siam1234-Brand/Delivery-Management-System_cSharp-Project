using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class EmployeeInfo : Form
    {
        public EmployeeInfo()
        {
            InitializeComponent();
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

        private void EmployeeInfo_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdate;
            string userQuery = $"SELECT EmployeeId FROM Employee WHERE Email='{staticWelcome.email}'";
            var idResult = Dbhelper.GetQueryData(userQuery);

            int Id = Convert.ToInt32(idResult.Data.Rows[0]["EmployeeId"]);

            try
            {
                string query = "SELECT * FROM employee WHERE EmployeeId =" + Id;
                var resultS = Dbhelper.GetQueryData(query);

                if (resultS.HasError)
                {
                    MessageBox.Show(resultS.Message);
                    return;
                }


                txtID.Text = resultS.Data.Rows[0]["EmployeeId"].ToString();
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

 


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userQuery = $"SELECT LoginId FROM Employee WHERE Email='{staticWelcome.email}'";
            var idResult = Dbhelper.GetQueryData(userQuery);

            int Id = Convert.ToInt32(idResult.Data.Rows[0]["LoginId"]);

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

            string query = $"UPDATE Employee SET Name='{name}', Password='{password}', DateOfBirth='{dob:yyyy-MM-dd}', Gender='{gender}', Contact='{contact}', Address='{address}' WHERE LoginId = {Id}";
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

       
                this.Close();

            
        }

        private void EmployeeInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Close();
                this.Owner.Show();

            }
        }

    }
}
