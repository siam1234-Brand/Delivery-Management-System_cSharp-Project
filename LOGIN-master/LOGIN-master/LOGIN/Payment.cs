using System;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private void LoadPayment(string searchValue = "")

        {
            try
            {
                string query = "select * from Payments";
                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query += " Where PaymentId = " + searchValue;
                }
                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvPayment.DataSource = Result.Data;
                dgvPayment.Refresh();
                dgvPayment.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error loading data: " + exception.Message);
            }

        }
        private void ResetCommand()
        {
            txtPaymentId.Text = "Auto Generated";
            txtShipmentId.Text = "";
            txtAmount.Text = "";
            cmbPaymentMethod.SelectedItem = null;
            dtpPaymentDate.Value = DateTime.Now;
            cmbPaymentStatus.SelectedItem = null;
            dgvPayment.ClearSelection();
        }
     
        private void Payment_Load(object sender, EventArgs e)
        {
            this.LoadPayment();
            this.ResetCommand();
            txtShipmentId.Text = staticWelcome.tempId;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadPayment(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadPayment();
            this.ResetCommand();
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtShipmentId.Text))
                {
                    MessageBox.Show("Shipment ID is required.");
                    return;
                }
                if (cmbPaymentMethod.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment method.");
                    return;
                }
                if (cmbPaymentStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please select a payment status.");
                    return;
                }
                dtpPaymentDate.Value = DateTime.Now;

                string query = "";
                if (txtPaymentId.Text == "Auto Generated")
                {
                    string Query = "UPDATE Shipment SET PaymentStatus='" + cmbPaymentStatus.SelectedItem + "' WHERE ShipmentId=" + txtShipmentId.Text;
                    var result1 = Dbhelper.ExecuteNonresultquery(Query);
                    if (result1.HasError)
                    {
                        MessageBox.Show(result1.Message);
                        return;
                    }

                    query = $"INSERT INTO Payments (ShipmentId, PaymentMethod, PaymentDate, PaymentStatus,Amount) " +
                            $"VALUES ({txtShipmentId.Text}, '{cmbPaymentMethod.SelectedItem}', '{dtpPaymentDate.Value:yyyy-MM-dd}', '{cmbPaymentStatus.SelectedItem}','{txtAmount.Text}')";
                }
                else
                {
                    string Query = "UPDATE Shipment SET PaymentStatus='" + cmbPaymentStatus.SelectedItem + "' WHERE ShipmentId=" + txtShipmentId.Text;
                    var result1 = Dbhelper.ExecuteNonresultquery(Query);
                    if (result1.HasError)
                    {
                        MessageBox.Show(result1.Message);
                        return;
                    }

                    query = $"UPDATE Payments SET ShipmentId={txtShipmentId.Text}, PaymentMethod='{cmbPaymentMethod.SelectedItem}', " +
                            $"PaymentDate='{dtpPaymentDate.Value:yyyy-MM-dd}', PaymentStatus='{cmbPaymentStatus.SelectedItem}',Amount='{txtAmount.Text}' " +
                            $"WHERE PaymentID={txtPaymentId.Text}";
                   
                }

                var result = Dbhelper.ExecuteNonresultquery(query);
                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }
                MessageBox.Show("Record saved successfully.");
                this.LoadPayment();
                this.ResetCommand();
                staticWelcome.tempId = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPaymentId.Text == "Auto Generated" || string.IsNullOrWhiteSpace(txtPaymentId.Text))
                {
                    MessageBox.Show("Please select a valid payment record to delete.");
                    return;
                }
                var confirmResult = MessageBox.Show("Are you sure to delete this payment record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                { 
                    string Status = "Unpaid";  
                    string Query = "UPDATE Shipment SET PaymentStatus='" +Status + "' WHERE ShipmentId=" + txtShipmentId.Text;
                    var result1 = Dbhelper.ExecuteNonresultquery(Query);
                    if (result1.HasError)
                    {
                        MessageBox.Show(result1.Message);
                        return;
                    }
                    string query = $"DELETE FROM Payments WHERE PaymentID={txtPaymentId.Text}";
                    var result = Dbhelper.ExecuteNonresultquery(query);
                    if (result.HasError)
                    {
                        MessageBox.Show(result.Message);
                        return;
                    }
                    MessageBox.Show("Record deleted successfully.");
                    this.LoadPayment();
                    this.ResetCommand();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void dgvPayment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.ResetCommand();
                if (e.RowIndex < 0)
                {

                    dgvPayment.ClearSelection();
                    return;
                }




                try
                {
                    int id = int.Parse(dgvPayment.Rows[e.RowIndex].Cells["PaymentID"].Value.ToString());

                    string query = "select * from Payments where PaymentID=" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvPayment.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }

                    txtPaymentId.Text = ResultS.Data.Rows[0]["PaymentID"].ToString();
                    txtShipmentId.Text = ResultS.Data.Rows[0]["ShipmentId"].ToString();
                    txtAmount.Text = ResultS.Data.Rows[0]["Amount"].ToString();
                    cmbPaymentMethod.SelectedItem = ResultS.Data.Rows[0]["PaymentMethod"].ToString();
                    Convert.ToDateTime(ResultS.Data.Rows[0]["PaymentDate"]);
                    cmbPaymentStatus.SelectedItem = ResultS.Data.Rows[0]["PaymentStatus"].ToString();






                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error loading data: " + exception.Message);
                }



            }

            catch (Exception exception)
            {
                MessageBox.Show("Error loading data: " + exception.Message);
            }
        }

        private void Payment_FormClosed(object sender, FormClosedEventArgs e)
        {

            staticWelcome.tempId = "";
        }

        private void txtShipmentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAmount.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPaymentMethod.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbPaymentMethod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPaymentStatus.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbPaymentStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}