using LOGIN;
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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
        private void LoadCustomer(string searchValue = "")
        {

            try
            {

               // string Clientid = $"SELECT ClientId FROM SignUp WHERE Email='{staticWelcome.email}'";

                //Result idResult = Dbhelper.GetQueryData(Clientid);
                //int ClientId = Convert.ToInt32(idResult.Data.Rows[0]["ClientId"]);

                string query = $"select * from Shipment  Where ReceiverEmail='{staticWelcome.email}'";
                if (!string.IsNullOrWhiteSpace(searchValue))
                {
                    query += " Where ShipmentId = " + searchValue;

                }
                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = Result.Data;
                dgvCustomer.Refresh();
                dgvCustomer.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
  



        private void Customer_Load(object sender, EventArgs e)
        {
            this.LoadCustomer();
        }

        private void btnSearchC_Click(object sender, EventArgs e)
        {
            this.LoadCustomer(txtSearchC.Text);

        }

        private void btnRefreshC_Click(object sender, EventArgs e)
        {
            txtSearchC.Text = "";
            this.LoadCustomer();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
