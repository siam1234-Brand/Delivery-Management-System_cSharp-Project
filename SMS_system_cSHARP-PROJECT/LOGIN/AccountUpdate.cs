using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LOGIN
{
    public partial class AccountUpdate : Form
    {
        public AccountUpdate()
        {
            InitializeComponent();
        }

        private void AccountUpdate_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnUpdate2;
            string Clientid = $"SELECT ClientId FROM SignUp WHERE Email='{staticWelcome.email}'";

            Result idResult = Dbhelper.GetQueryData(Clientid);
            int ClientId = Convert.ToInt32(idResult.Data.Rows[0]["ClientId"]);
            try
            {
                int id = ClientId;

                string query = "select * from SignUp where ClientId =" + id;
                var ResultS = Dbhelper.GetQueryData(query);

                if (ResultS.HasError)
                {
                    MessageBox.Show(ResultS.Message);
                }
                txtId.Text = ResultS.Data.Rows[0]["ClientId"].ToString();
                txtName.Text = ResultS.Data.Rows[0]["Name"].ToString();
                txtEmail.Text= ResultS.Data.Rows[0]["Email"].ToString();
                txtPassword2.Text= ResultS.Data.Rows[0]["Password"].ToString();
                dtpDob.Value = Convert.ToDateTime(ResultS.Data.Rows[0]["DateOfBirth"]);
                rdbMale.Checked = ResultS.Data.Rows[0]["Gender"].ToString().ToUpper() == "Male".ToUpper();
                rdbFemale.Checked = ResultS.Data.Rows[0]["Gender"].ToString().ToUpper() == "Female".ToUpper();
                txtContact.Text= ResultS.Data.Rows[0]["ClientContact"].ToString();
                txtAddress.Text= ResultS.Data.Rows[0]["Address"].ToString();



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnUpdate2_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword2.Text;
            DateTime dob = dtpDob.Value;
            string gender = rdbMale.Checked ? "Male" : rdbFemale.Checked ? "Female" : "";
            string contact = txtContact.Text;
            string address = txtAddress.Text;

            if (dob > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("invalid please add valid Date of Birth");
                return;
            }



            string query= "Update SignUp Set Name='" + name + "',Email='" +email + "',Password='" + password + "',DateOfBirth='" + dob + "',Gender='" + gender + "',ClientContact='" + contact + "' Where ClientId=" + txtId.Text;
            Result s = Dbhelper.ExecuteNonresultquery(query);

            if (s.HasError) { MessageBox.Show("Error creating profile: " + s.Message); return; }
            MessageBox.Show("Profile updated successfully!");


        }

    }
}
