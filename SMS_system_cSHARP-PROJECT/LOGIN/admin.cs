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
    public partial class admin : Form
    {
        EmployeeAdd emp = new EmployeeAdd();
        Shipment sh=new Shipment(); 
        CarrierAdd cr = new CarrierAdd();
        Route R = new Route();  
        public admin()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.pnlEmp.Controls.Clear();
            emp.TopLevel = false;
            emp.FormBorderStyle = FormBorderStyle.None;
            emp.AutoScroll = true;
            emp.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(emp);
            emp.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Hide();
                this.lblWelcome.Text += ", " + staticWelcome.name;
            }
        }

        private void admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }

        }

        private void btnShipment_Click(object sender, EventArgs e)
        {
            this.pnlEmp.Controls.Clear();
            sh.TopLevel = false;
            sh.FormBorderStyle = FormBorderStyle.None;
            sh.AutoScroll = true;
            sh.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(sh);
            sh.Show();
        }

        private void btnCarrier_Click(object sender, EventArgs e)
        {
            this.pnlEmp.Controls.Clear();
            cr.TopLevel = false;
            cr.FormBorderStyle = FormBorderStyle.None;
            cr.AutoScroll = true;
            cr.Dock = DockStyle.Fill;
            this.pnlEmp.Controls.Add(cr);
            cr.Show();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
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
