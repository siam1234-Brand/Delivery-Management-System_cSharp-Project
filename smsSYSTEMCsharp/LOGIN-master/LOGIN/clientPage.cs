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

namespace LOGIN
{
    public partial class clientPage : Form
    {
        Seller dfff = new Seller();
        Customer cff = new Customer();
       
        public clientPage()
        {
            InitializeComponent();
        }

        private void clientPage_Load(object sender, EventArgs e)
        {
            if(this.Owner != null)
            {

                this.Owner.Hide();
               this.lblWelcome.Text += ", "+staticWelcome.name;
            }
           

        }

        private void clientPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cmbClientType.SelectedItem=="Seller")
            {
                this.btnShipment.Visible = true;
                this.btnShowC.Visible = false;
                cff.Hide();
             

            }
            else if(cmbClientType.SelectedItem == "Customer")
                {
                 this.btnShipment.Visible = false;
                 this.btnShowC.Visible = true;
                 dfff.Hide(); 
            }
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            DialogResult box = MessageBox.Show("Are you sure?.", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (box == DialogResult.No)
                return;
            Application.Exit();
        }  

        private void btnShipment_Click(object sender, EventArgs e)
        {
            this.pnlClient.Controls.Clear();
           
            dfff.TopLevel = false;
            dfff.FormBorderStyle = FormBorderStyle.None;
            dfff.AutoScroll = true;
            dfff.Dock = DockStyle.Fill;
            this.pnlClient.Controls.Add(dfff);
            dfff.Show();
        }

        private void btnShowC_Click(object sender, EventArgs e)
        {
            this.pnlClient.Controls.Clear();

            cff.TopLevel = false;
            cff.FormBorderStyle = FormBorderStyle.None;
            cff.AutoScroll = true;
            cff.Dock = DockStyle.Fill;
            this.pnlClient.Controls.Add(cff);
            cff.Show();
        }

        private void btnAccountUp_Click(object sender, EventArgs e)
        {
            AccountUpdate up = new AccountUpdate();
            this.pnlClient.Controls.Clear();
            up.TopLevel = false;
            up.FormBorderStyle = FormBorderStyle.None;
            up.AutoScroll = true;
            up.Dock = DockStyle.Fill;
            this.pnlClient.Controls.Add(up);
            up.Show();

        }

        //delete account 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            string email = staticWelcome.email;
            string deleteQuery = $"DELETE FROM Signup WHERE Email = '{email}'";

            Result deleteResult = Dbhelper.ExecuteNonresultquery(deleteQuery);

            if (deleteResult.HasError)
            {
                MessageBox.Show("Error deleting account: " + deleteResult.Message);
                return;
            }

            MessageBox.Show("Your account has been deleted successfully.");

            this.Close();
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

        }

    }
}
