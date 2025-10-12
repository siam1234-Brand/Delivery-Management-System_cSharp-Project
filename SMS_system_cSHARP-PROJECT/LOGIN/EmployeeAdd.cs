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
    public partial class EmployeeAdd : Form
    {
        public EmployeeAdd()
        {
            InitializeComponent();
        }



        private void LoadEmployee(string searchValue = "")
        {
            try
            {
                string query = "select * from Employee";

                if (!string.IsNullOrWhiteSpace(searchValue))
                {

                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        query += " where EmployeeId =" + id + "OR Name LIKE'%" + searchValue + "%'";
                    }
                    else
                    {
                        query += " where Name LIKE '%" + searchValue + "%'";
                    }

                }
                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvEmployee.DataSource = Result.Data;
                dgvEmployee.Refresh();
                dgvEmployee.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void ResetCommand()
        {
            txtID.Text = "Auto Generated";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            dtpDob.Value = DateTime.Now;
            rdbMale.Checked = rdbFemale.Checked = false;
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }
        private void CheckEmail(string email = "")
        {
            string checkEmail = $"SELECT * FROM Signup WHERE Email = '{email}'";
            Result checkResult = Dbhelper.GetQueryData(checkEmail);

            if (!checkResult.HasError && checkResult.Data.Rows.Count > 0)
            {
                MessageBox.Show("This email is already registered. Please use a different email.");
                return;
            }
            string checkEmail1 = $"SELECT * FROM LOGIN WHERE Email = '{email}'";
            Result checkResult1 = Dbhelper.GetQueryData(checkEmail1);

            if (!checkResult1.HasError && checkResult1.Data.Rows.Count > 0)
            {
                MessageBox.Show("This email is already registered. Please use a different email.");
                return;
            }
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
             this.LoadEmployee();
            this.ResetCommand();
            this.AcceptButton = btnSave;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            this.LoadEmployee(txtSearch.Text);
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadEmployee();
            this.ResetCommand();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string Query;
            try
            {
                string Name = txtName.Text;
                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("invalid please add Name ");
                    return;
                }
                string email = txtEmail.Text;

                if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                {
                    MessageBox.Show("invalid, please add valid Email");
                    return;
                }
                string Password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(Password) || Password.Length < 4)
                {
                    MessageBox.Show("invalid,Please add valid Password (Atlist 4 Charecter.)");
                    return;
                }
                DateTime dob = dtpDob.Value;
                if (dob > DateTime.Now.AddYears(-18))
                {
                    MessageBox.Show("invalid please add valid Date of Birth");
                    return;
                }
                string gender = rdbMale.Checked ? rdbMale.Text : rdbFemale.Checked ? rdbFemale.Text : "";
                if (string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("invalid please select gender");
                    return;
                }
                string Contact = txtContact.Text;
                if (string.IsNullOrWhiteSpace(Contact))
                {
                    MessageBox.Show("invalid please add Contact ");
                    return;
                }
                else
                {
                    if (Contact.StartsWith("+880"))
                    {
                        Contact = Contact.Substring(3);
                    }
                    else if (Contact.StartsWith("880"))
                    {
                        Contact = Contact.Substring(2);
                    }

                    if (!Contact.All(char.IsDigit))
                    {
                        MessageBox.Show("Invalid Number");
                        return;
                    }

                    if (Contact.Length == 11 && Contact.StartsWith("01"))
                    {
                        char thirdDigit = Contact[2];
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
                }
                string Address = txtAddress.Text;
                if (string.IsNullOrWhiteSpace(Address))
                {
                    MessageBox.Show("invalid please add Address ");
                    return;
                }



                if (txtID.Text == "Auto Generated")
                {
                    string Role = "Employee";
                    string Query1 = $"INSERT INTO LOGIN (Name,Email,Password,Role) " +
                    $"VALUES ('{Name}', '{email}', '{Password}', '{Role}')";
                    var Result1 = Dbhelper.ExecuteNonresultquery(Query1);
                    if (Result1.HasError)
                    {
                        MessageBox.Show(Result1.Message);
                        return;
                    }

                    string Query2 = $"SELECT UserId FROM LOGIN WHERE Email='{email}'";
                    var idResult = Dbhelper.GetQueryData(Query2);
                    if (idResult.HasError)
                    {
                        MessageBox.Show(idResult.Message);
                        return;
                    }

                    int Id = Convert.ToInt32(idResult.Data.Rows[0]["UserId"].ToString());
                    Query = $"INSERT INTO Employee(LoginId,Name,Email,Password,DateOfBirth,Gender,Contact,Address)" +
                            $"Values('{Id}','{Name}', '{email}', '{Password}', '{dob}','{gender}','{Contact}','{Address}')";
                }
                else
                {
                    string Query2 = "SELECT LoginId FROM Employee WHERE EmployeeId =" + txtID.Text;
                    var idResult = Dbhelper.GetQueryData(Query2);
                    if (idResult.HasError)
                    {
                        MessageBox.Show(idResult.Message);
                        return;
                    }

                    int Id = Convert.ToInt32(idResult.Data.Rows[0]["LoginId"].ToString());
                    string Query4 = "UPDATE LOGIN SET " + "Name = '" + Name + "', " + "Email = '" + email + "', " + "Password = '" + Password + "' " + "WHERE UserId = " + Id;
                    var Result4 = Dbhelper.ExecuteNonresultquery(Query4);
                    if (Result4.HasError)
                    {
                        MessageBox.Show(Result4.Message);
                        return;
                    }
                    Query = "UPDATE Employee SET " + "Name = '" + Name + "', " + "Email = '" + email + "', " + "Password = '" + Password + "', " + "DateOfBirth = '" + dob + "', " + "Gender = '" + gender + "', " + "Contact = '" + Contact + "', " + "Address = '" + Address + "' " + "WHERE EmployeeId = " + txtID.Text;
                }





                var Result = Dbhelper.ExecuteNonresultquery(Query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message); return;
                }

                MessageBox.Show("Data saved successfully");
                this.LoadEmployee();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            this.ResetCommand();

        }

   

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.ResetCommand();
                if (e.RowIndex < 0)
                {

                    dgvEmployee.ClearSelection();
                    return;
                }
                int id = int.Parse(dgvEmployee.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString());

                try
                {

                    string query = "select * from Employee where EmployeeId=" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvEmployee.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }

                    txtID.Text = ResultS.Data.Rows[0]["EmployeeId"].ToString();
                    txtName.Text = ResultS.Data.Rows[0]["Name"].ToString();
                    txtEmail.Text = ResultS.Data.Rows[0]["Email"].ToString();
                    txtPassword.Text = ResultS.Data.Rows[0]["Password"].ToString();
                    dtpDob.Value = Convert.ToDateTime(ResultS.Data.Rows[0]["DateOfBirth"]);
                    rdbMale.Checked = ResultS.Data.Rows[0]["Gender"].ToString().ToUpper() == "MAle".ToUpper();
                    rdbFemale.Checked = ResultS.Data.Rows[0]["Gender"].ToString().ToUpper() == "Female".ToUpper();
                    txtContact.Text = ResultS.Data.Rows[0]["Contact"].ToString();
                    txtAddress.Text = ResultS.Data.Rows[0]["Address"].ToString();


                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "Auto Generated")
                {
                    MessageBox.Show("please select a row ");
                }
                else
                {

                    string Query2 = "SELECT LoginId FROM employee WHERE EmployeeId =" + txtID.Text;
                    var idResult = Dbhelper.GetQueryData(Query2);
                    if (idResult.HasError)
                    {
                        MessageBox.Show(idResult.Message);
                        return;
                    }

                    int Id = Convert.ToInt32(idResult.Data.Rows[0]["LoginId"].ToString());

                    string Query1 = "delete from Employee where EmployeeId=" + txtID.Text;
                    var result1 = Dbhelper.ExecuteNonresultquery(Query1);
                    if (result1.HasError)
                    {
                        MessageBox.Show(result1.Message);
                    }



                    String query = "delete from LOGIN where UserId=" + Id;

                    var result = Dbhelper.ExecuteNonresultquery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                    }

                    MessageBox.Show("Deleted!");
                    this.LoadEmployee();
                    this.ResetCommand();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
                return;

            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }


        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
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
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
