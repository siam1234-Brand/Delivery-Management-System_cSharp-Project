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
    public partial class carrierPage : Form
    {
        public carrierPage()
        {
            InitializeComponent();
        }
        private void ResetCommand()
        {
            txtId.Text = "";
            cmbcrStatus.SelectedItem = null;
            dgvCarrier.ClearSelection();
        }   
        private void LoadCarrier(string SearchValue = "")
        {

            try
            {

                string Carrierid = $"SELECT CarrierId FROM Carrier WHERE Email='{staticWelcome.email}'";

                Result idResult = Dbhelper.GetQueryData(Carrierid);
                int Id = Convert.ToInt32(idResult.Data.Rows[0]["CarrierId"].ToString());


                string query = "select * from Shipment Where Carrier=" + Id;
                if (!string.IsNullOrWhiteSpace(SearchValue))
                {
                    query += "and ShipmentId LIKE '%" + SearchValue + "%'";

                }



                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvCarrier.DataSource = Result.Data;
                dgvCarrier.Refresh();
                dgvCarrier.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void carrierPage_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
                this.lblWelcome.Text += ", " + staticWelcome.name;
            }
            
        }


        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void carrierPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            this.LoadCarrier();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = cmbcrStatus.SelectedItem == null ? "" : cmbcrStatus.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("invalid please add Tracking ststus.");
                return;
            }
            string Query = "UPDATE Shipment SET TrackingStatus='" + cmbcrStatus.SelectedItem + "' WHERE ShipmentId="+txtId.Text ;
            var Result = Dbhelper.ExecuteNonresultquery(Query);
            if (Result.HasError)
            {
                MessageBox.Show(Result.Message); return;
            }
            MessageBox.Show("Data updated successfully");
            this.LoadCarrier();
            this.ResetCommand();
        }

        private void dgvCarrier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex < 0)
                {

                    dgvCarrier.ClearSelection();
                    return;
                }



                try
                {
                    int id = int.Parse(dgvCarrier.Rows[e.RowIndex].Cells["ShipmentId"].Value.ToString());

                    string query = "select * from Shipment where ShipmentId=" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvCarrier.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }

                    
                    cmbcrStatus.SelectedItem = ResultS.Data.Rows[0]["TrackingStatus"].ToString();
                    txtId.Text = ResultS.Data.Rows[0]["ShipmentId"].ToString();
                   




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

        private void btnInfo_Click_1(object sender, EventArgs e)
        {

            CarrierInfo info = new CarrierInfo();
            info.Show();
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbcrStatus.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbcrStatus_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
