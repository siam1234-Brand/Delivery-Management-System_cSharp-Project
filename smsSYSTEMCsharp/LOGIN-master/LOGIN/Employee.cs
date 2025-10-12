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
    public partial class Employee : Form
    {
        CarrierAdd cff = new CarrierAdd();
        Shipment sff = new Shipment();
        EmployeeInfo employeeInfo= new EmployeeInfo();

        public Employee()
        {
            InitializeComponent();
        }
       
        private void Employee_Load(object sender, EventArgs e)
        {

            if (this.Owner != null)
            {

                this.Owner.Hide();
                this.lblWelcome.Text += ", " + staticWelcome.name;
            }
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            
         
            this.pnlEmp.Controls.Clear();
            sff.TopLevel = false;
            sff.FormBorderStyle = FormBorderStyle.None;
            sff.AutoScroll = true;
            sff.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(sff);
            sff.Show();
        }

        private void btnCarrier_Click(object sender, EventArgs e)
        {

            this.pnlEmp.Controls.Clear();
            cff.TopLevel = false;
            cff.FormBorderStyle = FormBorderStyle.None;
            cff.AutoScroll = true;
            cff.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(cff);
            cff.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.employeeInfo.Show();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            Route R=new Route();
            this.pnlEmp.Controls.Clear();
            R.TopLevel = false;
            R.FormBorderStyle = FormBorderStyle.None;
            R.AutoScroll = true;
            R.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(R);
            R.Show();

        }
    }
}
