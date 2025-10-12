using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LOGIN
{
    public partial class Route : Form
    {
        public Route()
        {
            InitializeComponent();
        }

        private void ResetCommand()
        {

            txtID.Text= "Auto Generated";
            txtDestination.Text = "";
            txtOrigin.Text = "";
            txtSearch.Text = "";



        }
        private void LoadRoute(string searchValue="")
        {
            try
            {
                string query = "select * from Route";


                if (!string.IsNullOrWhiteSpace(searchValue))
                {

                    int id;
                    if (int.TryParse(searchValue, out id))
                    {
                        query += " where RouteId =" + id ;
                    }
                    

                }
                var Result = Dbhelper.GetQueryData(query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message);
                }
                dgvRoute.DataSource = Result.Data;
                dgvRoute.Refresh();
                this.ResetCommand();
                dgvRoute.ClearSelection();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }



        }
        private void Route_Load(object sender, EventArgs e)
        {
            this.LoadRoute();
            this.ResetCommand();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.LoadRoute(txtSearch.Text);   
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

                    string Query1 = "delete from Shipment where RouteId=" + txtID.Text;
                    var result1 = Dbhelper.ExecuteNonresultquery(Query1);
                    if (result1.HasError)
                    {

                        MessageBox.Show(result1.Message);
                    }

                    string Query2 = "delete from Route where RouteId=" + txtID.Text;
                    var result2 = Dbhelper.ExecuteNonresultquery(Query2);
                    if (result2.HasError)
                    {
                        MessageBox.Show(result2.Message);
                    }

                    MessageBox.Show("Your Route has been delete successfully");
                    this.LoadRoute();
                }

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
                return;

            }
        }

        private void dgvRoute_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.ResetCommand();
                if (e.RowIndex < 0)
                {

                    dgvRoute.ClearSelection();
                    return;
                }


                try
                {
                    int id = int.Parse(dgvRoute.Rows[e.RowIndex].Cells["RouteId"].Value.ToString());

                    string query = "select * from Route where RouteId =" + id;
                    var ResultS = Dbhelper.GetQueryData(query);
                    dgvRoute.DataSource = ResultS.Data;
                    if (ResultS.HasError)
                    {
                        MessageBox.Show(ResultS.Message);
                    }
                    txtID.Text = ResultS.Data.Rows[0]["RouteId"].ToString();
                    txtOrigin.Text= ResultS.Data.Rows[0]["Origin"].ToString();
                    txtDestination.Text= ResultS.Data.Rows[0]["Destination"].ToString();


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
            this.LoadRoute();
            this.ResetCommand();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Save = MessageBox.Show("Your shipment will be saved.", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (Save == DialogResult.Cancel) return;


                string Origin = txtOrigin.Text;
                if (string.IsNullOrWhiteSpace(Origin))
                {
                    MessageBox.Show("invalid please add Origin ");
                    return;
                }
                string Destination = txtDestination.Text;
                if (string.IsNullOrWhiteSpace(Destination))
                {
                    MessageBox.Show("invalid please add Destination ");
                    return;
                }
               
                var query = $"SELECT Origin, Destination FROM Route WHERE Origin = '{Origin}' AND Destination = '{Destination}'";
                var result = Dbhelper.GetQueryData(query);
                

                if (result.HasError)
                {
                    MessageBox.Show(result.Message);
                    return;
                }

                if (result.Data.Rows.Count == 1)
                {
                    MessageBox.Show("Origin & Destination already exist");
                    return;
                }

                string Query;
                if (txtID.Text == "Auto Generated")
                {
                    Query = $"INSERT INTO Route (Origin,Destination) " +
                $"VALUES ('{Origin}','{Destination}')";
                }
                else
                {
                    Query = "Update Route Set Origin='" + Origin + "',Destination='" + Destination + "' Where RouteId=" + txtID.Text;
                }



                var Result = Dbhelper.ExecuteNonresultquery(Query);
                if (Result.HasError)
                {
                    MessageBox.Show(Result.Message); return;
                }


                MessageBox.Show("Your new Route has been saved successfully.");
                this.LoadRoute();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
