using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LOGIN
{
    public partial class Shipment : Form
    {
        public Shipment()
        {
            InitializeComponent();
        }

        private void ResetCommand()
        {
            txtId.Text = "Auto Generated";
            cmbTrackingStatus.SelectedItem = null;
            txtGoods.Text = "";
            txtWeight.Text = "";
            txtVol.Text = "";
            txtPickUP.Text = "";
            txtDestination.Text = "";
            dateTimePicker1.Value = DateTime.Now.AddDays(3);
            txtClient.Text = "";
            txtRouteId.Text = "";
            cmbCarrier.SelectedItem =null;
            dgvEmployee.ClearSelection();
        }
        private string GetPaymentStatus()
        {
            string query = "SELECT PaymentStatus FROM Shipment WHERE ShipmentId = " + txtId.Text;
            var result = Dbhelper.GetQueryData(query);

            if (result.HasError)
            {
                MessageBox.Show(result.Message);
                return "";
            }

            

            return result.Data.Rows[0]["PaymentStatus"].ToString();
        }
        public void LoadShipment(string searchValue="")
        {
          
            try
            {
                string query = "select * from Shipment";
                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query += " Where ShipmentId = " + searchValue;
                    
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
            this.ResetCommand();

        }

        private void LoadCarrier()
        {

            var query = "select * from Carrier";
            var result = Dbhelper.GetQueryData(query);
            if (result.HasError)
            {
                MessageBox.Show(result.Message);
            }
            cmbCarrier.DataSource = result.Data;
            cmbCarrier.DisplayMember = "Name";
            cmbCarrier.ValueMember = "CarrierId";
            cmbCarrier.SelectedIndex = 0;
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadShipment(txtSearch.Text);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.LoadShipment();
            this.LoadCarrier();
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

                int id = int.Parse(dgvEmployee.Rows[e.RowIndex].Cells["ShipmentId"].Value.ToString());

                try
                {
                    string query = "select * from Shipment where ShipmentId=" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvEmployee.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }

                    txtId.Text = ResultS.Data.Rows[0]["ShipmentId"].ToString();
                    staticWelcome.tempId = txtId.Text;
                    txtClient.Text = ResultS.Data.Rows[0]["ClientId"].ToString();
                    txtRouteId.Text = ResultS.Data.Rows[0]["RouteId"].ToString();
                    cmbTrackingStatus.SelectedItem = ResultS.Data.Rows[0]["TrackingStatus"].ToString();
                    txtGoods.Text = ResultS.Data.Rows[0]["TypeOfGoods"].ToString();
                    txtWeight.Text = ResultS.Data.Rows[0]["Weight"].ToString();
                    txtVol.Text = ResultS.Data.Rows[0]["Volume"].ToString();
                    txtPickUP.Text = ResultS.Data.Rows[0]["PickUpAddress"].ToString();
                    txtDestination.Text = ResultS.Data.Rows[0]["Destination"].ToString();
                    cmbCarrier.SelectedValue = ResultS.Data.Rows[0]["Carrier"];
                    if (ResultS.Data.Rows[0]["EstimatedDeliveryTime"] != DBNull.Value)
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(ResultS.Data.Rows[0]["EstimatedDeliveryTime"]);
                    }
                    else
                    {
                        dateTimePicker1.Value = DateTime.Now.AddDays(3);


    
                    }


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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a shipment to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCarrier.Text))
            {
                MessageBox.Show("Please select a Carrier to update.");
                return;
            }

            string paymentStatus = this.GetPaymentStatus();

            if (paymentStatus == "Unpaid")
            {
                MessageBox.Show("Please complete the payment.");
                return;
            }


            dateTimePicker1.Value = DateTime.Now.AddDays(3);
            string Query = "UPDATE Shipment SET TrackingStatus='" + cmbTrackingStatus.SelectedItem + "',TypeOfGoods='" + txtGoods.Text
            + "',EstimatedDeliveryTime='" + dateTimePicker1.Value + "',Carrier='" + cmbCarrier.SelectedValue + "' WHERE ShipmentId=" + txtId.Text;
            var Result = Dbhelper.ExecuteNonresultquery(Query); 
            if (Result.HasError)
            {
                MessageBox.Show(Result.Message); return;
            }
            MessageBox.Show("Data updated successfully");
            this.ResetCommand();
            this.LoadShipment();

        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
          
            Payment p = new Payment();
            p.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "Auto Generated")
                {
                    MessageBox.Show("please select a row ");
                    return;
                }
                else
                {

                    String query = "delete from Payments where shipmentId =" + txtId.Text;
                    String query1 = "delete from Shipment where ShipmentId=" + txtId.Text;
                  

                    var result = Dbhelper.ExecuteNonresultquery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                    }

                    var result1 = Dbhelper.ExecuteNonresultquery(query1);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                    }
                    MessageBox.Show("Deleted!");
                   
                    this.LoadShipment();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
                return;
            }
        }

        private void Shipment_Load(object sender, EventArgs e)
        { 
            this.LoadShipment();
            this.LoadCarrier();
            this.ResetCommand();
        }


        private void cmbCarrier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbTrackingStatus.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbTrackingStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
