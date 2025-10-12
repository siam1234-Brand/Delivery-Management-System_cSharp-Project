using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class CarrierAdd : Form
    {
        public CarrierAdd()
        {
            InitializeComponent();
        }


        private void LoadCarrier(string searchValue = "")
        {
            try
            {
                string query = "select * from Carrier";


                if (!string.IsNullOrWhiteSpace(searchValue))
                {

                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        query += " where CarrierId =" + id + "OR Name LIKE'%" + searchValue + "%'";
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
                dgvCarrier.DataSource = Result.Data;
                dgvCarrier.Refresh();
                this.ResetCommand();
                dgvCarrier.ClearSelection();

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

            if (!checkResult.HasError && checkResult.Data.Rows.Count > 0) { 
           
                MessageBox.Show("Email already in use. Use another email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }
            string checkEmail1 = $"SELECT * FROM LOGIN WHERE Email = '{email}'";
            Result checkResult1 = Dbhelper.GetQueryData(checkEmail1);

            if (!checkResult1.HasError && checkResult1.Data.Rows.Count > 0)
            {
               MessageBox.Show("Email already in use. Use another email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void CarrierAddd_Load(object sender, EventArgs e)
        {
            this.LoadCarrier();
            this.ResetCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadCarrier(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadCarrier();
            this.ResetCommand();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text;
                if (string.IsNullOrWhiteSpace(Name))
                {
                    MessageBox.Show("Please enter a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                string email = txtEmail.Text;
                var parts = email.Split('@');
                if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                {
                    MessageBox.Show("Invalid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return;
                }
                string Password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(Password) || Password.Length < 4)
                {
                    MessageBox.Show("Please enter a valid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtPassword.Focus();
                    txtPassword.SelectAll();
                    return;
                }
                DateTime dob = dtpDob.Value;
                if (dob > DateTime.Now.AddYears(-10))
                {
                    MessageBox.Show("Please enter a valid date of birth.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                }

                string gender = rdbMale.Checked ? rdbMale.Text : rdbFemale.Checked ? rdbFemale.Text : "";
                if (string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Please choose a gender.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                }
                string contact = txtContact.Text.Trim();

                if (string.IsNullOrWhiteSpace(contact))

                {
                    MessageBox.Show("Please enter a contact number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtContact.Focus();
                    txtContact.SelectAll();
                    return;

                }


                if (contact.StartsWith("+880"))

                    contact = contact.Substring(3);

                else if (contact.StartsWith("880"))

                    contact = contact.Substring(2);


                if (!contact.All(char.IsDigit))

                {

                    MessageBox.Show("Invalid number. Only digits allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtContact.Focus();

                    txtContact.SelectAll();

                    return;

                }


                if (contact.Length != 11 || !contact.StartsWith("01") || contact[2] < '3' || contact[2] > '9')

                {

                    MessageBox.Show("Invalid mobile number format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtContact.Focus();

                    txtContact.SelectAll();

                    return;

                }
                string address=txtAddress.Text.Trim();

                if (string.IsNullOrWhiteSpace(txtAddress.Text))

                {

                    MessageBox.Show("Please enter an address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    txtAddress.Focus();

                    txtAddress.SelectAll();

                    return;

                }


            


                this.CheckEmail(email);
                string Query;
            

                if (txtID.Text == "Auto Generated")
                {
                    string Role = "Carrier";
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
                    Query = $"INSERT INTO Carrier(LoginId,Name,Email,Password,DateOfBirth,Gender,Contact,Address)" +
                            $"Values('{Id}','{Name}', '{email}', '{Password}', '{dob}','{gender}','{contact}','{address}')";
                }
                else
                {
                    string Query2 = "SELECT LoginId FROM Carrier WHERE CarrierId ="+txtID.Text;
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
                    Query = "UPDATE Carrier SET " + "Name = '" + Name + "', " + "Email = '" + email + "', " + "Password = '" + Password + "', " + "DateOfBirth = '" + dob + "', " + "Gender = '" + gender + "', " + "Contact = '" + contact + "', " + "Address = '" + address + "' " + "WHERE CarrierId = " + txtID.Text;
                }


               


                var Result = Dbhelper.ExecuteNonresultquery(Query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message); return;
                }

                MessageBox.Show("Data saved successfully");
                this.LoadCarrier();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

      

        private void dgvCarrier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.ResetCommand();
                if (e.RowIndex < 0)
                {

                    dgvCarrier.ClearSelection();
                    return;
                }

                try
                {
                    int id = int.Parse(dgvCarrier.Rows[e.RowIndex].Cells["CarrierId"].Value.ToString());

                    string query = "select * from Carrier where CarrierId="+ id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvCarrier.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }

                    txtID.Text = ResultS.Data.Rows[0]["CarrierId"].ToString();
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
                    MessageBox.Show("Please select a row ");
                    return;
                }
                else
                {

                    string Query2 = "SELECT LoginId FROM Carrier WHERE CarrierId =" + txtID.Text;
                    var idResult = Dbhelper.GetQueryData(Query2);
                    if (idResult.HasError)
                    {
                        MessageBox.Show(idResult.Message);
                        return;
                    }


                    DialogResult box = MessageBox.Show("Are you sure you want to delete the carrier?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (box == DialogResult.No)
                        return;

                    int Id = Convert.ToInt32(idResult.Data.Rows[0]["LoginId"].ToString());

                    string Query1 = "delete from Carrier where CarrierId=" + txtID.Text;
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

                    this.LoadCarrier();
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
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPassword.Focus();
            }

            else if (e.KeyCode == Keys.Up)
            {
                txtName.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtContact.Focus();
            }

            else if (e.KeyCode == Keys.Up)
            {
                txtPassword.Focus();
            }
        }
        private void txtContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtAddress.Focus();
            }

            else if (e.KeyCode == Keys.Up)
            {
                txtContact.Focus();
            }
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }

            else if (e.KeyCode == Keys.Up)
            {
                txtAddress.Focus();
            }
        }

       
    }
}
