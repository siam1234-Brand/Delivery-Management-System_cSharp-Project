namespace LOGIN
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCarrier = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.btnRoute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlEmp, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 718);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRoute);
            this.panel1.Controls.Add(this.btnCarrier);
            this.panel1.Controls.Add(this.btnShipment);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 712);
            this.panel1.TabIndex = 0;
            // 
            // btnCarrier
            // 
            this.btnCarrier.BackColor = System.Drawing.Color.Indigo;
            this.btnCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrier.ForeColor = System.Drawing.Color.Thistle;
            this.btnCarrier.Location = new System.Drawing.Point(45, 328);
            this.btnCarrier.Name = "btnCarrier";
            this.btnCarrier.Size = new System.Drawing.Size(335, 55);
            this.btnCarrier.TabIndex = 4;
            this.btnCarrier.Text = "ADD CARRIER";
            this.btnCarrier.UseVisualStyleBackColor = false;
            this.btnCarrier.Click += new System.EventHandler(this.btnCarrier_Click);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.Color.Indigo;
            this.btnShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipment.ForeColor = System.Drawing.Color.Thistle;
            this.btnShipment.Location = new System.Drawing.Point(41, 229);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(335, 55);
            this.btnShipment.TabIndex = 3;
            this.btnShipment.Text = "ADD SHIPMENT";
            this.btnShipment.UseVisualStyleBackColor = false;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Indigo;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Thistle;
            this.btnEmployee.Location = new System.Drawing.Point(41, 135);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(335, 55);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "ADD EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Romantic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(9, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(197, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME";
            // 
            // pnlEmp
            // 
            this.pnlEmp.BackColor = System.Drawing.Color.Thistle;
            this.pnlEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmp.Location = new System.Drawing.Point(435, 3);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(670, 712);
            this.pnlEmp.TabIndex = 1;
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.Color.Indigo;
            this.btnRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoute.ForeColor = System.Drawing.Color.Thistle;
            this.btnRoute.Location = new System.Drawing.Point(45, 418);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(335, 55);
            this.btnRoute.TabIndex = 5;
            this.btnRoute.Text = "ADD ROUTE";
            this.btnRoute.UseVisualStyleBackColor = false;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "admin";
            this.Text = "admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.admin_FormClosed);
            this.Load += new System.EventHandler(this.admin_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Button btnCarrier;
        private System.Windows.Forms.Button btnRoute;
    }
}