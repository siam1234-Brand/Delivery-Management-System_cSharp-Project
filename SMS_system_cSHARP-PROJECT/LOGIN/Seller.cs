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
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void ResetCommand()
        {
            txtIdSeller.Text = "Auto Generated";
            txtGoods.Text = "";
            txtWeight.Text = "";
            txtVolume.Text = "";
            txtREmail.Text = "";
            txtRName.Text = "";
            cmbOrigin.SelectedItem = null;  
            cmbDestination.SelectedItem = null;
            dgvSeller.ClearSelection();
            txtSearch.Text = "";
        }
        private bool CheckEmail(string email = "")
        {
            bool emailExists = false;

            string checkEmailSignup = $"SELECT * FROM Signup WHERE Email = '{email}'";
            Result resultSignup = Dbhelper.GetQueryData(checkEmailSignup);

            if (!resultSignup.HasError && resultSignup.Data.Rows.Count > 0)
            {
                emailExists = true;
                return emailExists; 
            }
            string checkEmailLogin = $"SELECT * FROM LOGIN WHERE Email = '{email}'";
            Result resultLogin = Dbhelper.GetQueryData(checkEmailLogin);

            if (!resultLogin.HasError && resultLogin.Data.Rows.Count > 0)
            {
                emailExists = true;
                return emailExists; 
            }

            return emailExists;
        }
        private void LoadShipment(string searchValue="")
        {
            try
            {
                string Clientid = $"SELECT ClientId FROM SignUp WHERE Email='{staticWelcome.email}'";

                Result idResult = Dbhelper.GetQueryData(Clientid);
                int ClientId = Convert.ToInt32(idResult.Data.Rows[0]["ClientId"]);

                string query = "select * from Shipment Where ClientId="+ClientId;
                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query += "and ShipmentId LIKE '%" + searchValue + "%'";

                }

                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvSeller.AutoGenerateColumns = false;
                dgvSeller.DataSource = Result.Data;
                dgvSeller.Refresh();
                this.ResetCommand();
                dgvSeller.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadRoute()
        {

            var query = "select distinct Origin from Route";
            var result = Dbhelper.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
            }
            cmbOrigin.DataSource = result.Data;
            cmbOrigin.DisplayMember = "Origin";
            cmbOrigin.ValueMember = "Origin";
            cmbOrigin.SelectedIndex = 0;

            var query1 = "select distinct Destination from Route";
            var result1 = Dbhelper.GetQueryData(query1);
            if (result1.HasError)
            {
                MessageBox.Show(result1.Message);
            }
            cmbDestination.DataSource = result1.Data;
            cmbDestination.DisplayMember = "Destination";
            cmbDestination.ValueMember = "Destination";
            cmbDestination.SelectedIndex = 0;


        }
        private void Seller_Load(object sender, EventArgs e)
        {
            this.LoadShipment();
            this.LoadRoute();
            this.ResetCommand();
        }

        private void dgvSeller_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.ResetCommand();
                if (e.RowIndex < 0)
                {

                    dgvSeller.ClearSelection();
                    return;
                }

                try
                {
                    int id = int.Parse(dgvSeller.Rows[e.RowIndex].Cells["dgvShipmentId"].Value.ToString());

                    string query = "select * from  Shipment where ShipmentId =" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvSeller.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }
                    txtIdSeller.Text = ResultS.Data.Rows[0][0].ToString();
                    txtGoods.Text = ResultS.Data.Rows[0]["TypeOfGoods"].ToString(); 
                    txtWeight.Text = ResultS.Data.Rows[0]["Weight"].ToString();
                    txtVolume.Text = ResultS.Data.Rows[0]["Volume"].ToString();
                    cmbOrigin.SelectedValue= ResultS.Data.Rows[0]["PickUpAddress"].ToString();
                    cmbDestination.SelectedValue= ResultS.Data.Rows[0][6].ToString();
                    txtRName.Text= ResultS.Data.Rows[0]["ReceiverName"].ToString();
                    txtREmail.Text= ResultS.Data.Rows[0]["ReceiverEmail"].ToString();


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
            {

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadShipment();
            this.ResetCommand();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Your shipment will be saved.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (confirm == DialogResult.Cancel) return;


                string TypeOfGoods = txtGoods.Text;
                if (string.IsNullOrWhiteSpace(TypeOfGoods))
                {
                    MessageBox.Show("invalid please add Type Of Goods ");
                    return;
                }
                string Weight = txtWeight.Text;
                if (string.IsNullOrWhiteSpace(Weight))
                {
                    MessageBox.Show("invalid please add Weight ");
                    return;
                }
                string Volume = txtVolume.Text;
                if (string.IsNullOrWhiteSpace(Volume))
                {
                    MessageBox.Show("invalid please add Volume ");
                    return;
                }
                string REmail = txtREmail.Text;
                if (string.IsNullOrWhiteSpace(REmail))
                {
                    MessageBox.Show("invalid please add Valid Email ");
                    return;
                }
                string RName = txtRName.Text;
                if (string.IsNullOrWhiteSpace(RName))
                {
                    MessageBox.Show("invalid please add Name ");
                    return;
                }

                string PickUpAddress = cmbOrigin.SelectedValue == null ? "" : cmbOrigin.SelectedValue.ToString();
                string Destination = cmbDestination.SelectedValue == null ? "" : cmbDestination.SelectedValue.ToString();
                if (cmbOrigin.SelectedValue == null || cmbDestination.SelectedValue == null)
                {
                    MessageBox.Show("Please select both Origin and Destination.");
                    return;
                }
               
                if (this.CheckEmail(REmail)==false)
                {
                    string insertsignup = $"INSERT INTO SignUp (Name, Email, Role) "
                        + $"VALUES ('{RName}', '{REmail}', 'Client')";

                    Result signupResult = Dbhelper.ExecuteNonresultquery(insertsignup);

                    if (signupResult.HasError) { MessageBox.Show("Error creating profile: " + signupResult.Message); return; }

                }





                if (PickUpAddress == Destination)
                {
                    MessageBox.Show("Origin and Destination cannot be the same. Please select different locations.");
                    return;
                }

                string query = $"SELECT RouteID FROM Route WHERE Origin = '{PickUpAddress}' AND Destination = '{Destination}'";
                Result idRoute = Dbhelper.GetQueryData(query);
                if (idRoute.HasError || idRoute.Data.Rows.Count == 0) { MessageBox.Show("Error retrieving UserId."); return; }
               

                int RouteId = Convert.ToInt32(idRoute.Data.Rows[0]["RouteId"]);
               

                string status = "Pending";
                string paymentStatus = "Unpaid";


                string Clientid = $"SELECT ClientId FROM SignUp WHERE Email='{staticWelcome.email}'";

                Result idResult = Dbhelper.GetQueryData(Clientid);

                if (idResult.HasError || idResult.Data.Rows.Count == 0) { MessageBox.Show("Error retrieving UserId."); return; }

                int ClientId = Convert.ToInt32(idResult.Data.Rows[0]["ClientId"]);


                string Query;
                if (txtIdSeller.Text == "Auto Generated")
                {
                    Query = $"INSERT INTO Shipment (TypeOfGoods, Weight, Volume, PickUpAddress, Destination,ClientId,TrackingStatus,PaymentStatus,RouteId,ReceiverName,ReceiverEmail) " +
                $"VALUES ('{TypeOfGoods}', {Weight}, {Volume}, '{PickUpAddress}', '{Destination}','{ClientId}','{status}','{paymentStatus}','{RouteId}','{RName}','{REmail}')";

                }
                else
                {
                    Query = "Update Shipment Set TypeOfGoods='" + TypeOfGoods + "',Weight='" + Weight + "',Volume='" + Volume + "',PickUpAddress='" + PickUpAddress + "',Destination='" + Destination + "',ReceiverName='" + RName + "',ReceiverEmail='" + REmail + "' Where ShipmentId=" + txtIdSeller.Text;
                }

               


                var Result = Dbhelper.ExecuteNonresultquery(Query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message); return;
                }


                MessageBox.Show("Your shipment has been saved successfully.");
                this.LoadShipment();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           this.LoadShipment(txtSearch.Text);
        }

        private void txtGoods_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtWeight.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtVolume.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtVolume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbOrigin.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void cmbOrigin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDestination.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbDestination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

     }
 }

