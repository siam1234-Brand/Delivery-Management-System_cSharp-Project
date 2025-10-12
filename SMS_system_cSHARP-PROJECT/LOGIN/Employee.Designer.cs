namespace LOGIN
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnCarrier = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlEmp = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnRoute = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlEmp, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 696);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnRoute);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.btnCarrier);
            this.panel1.Controls.Add(this.btnShipment);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 690);
            this.panel1.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInfo.Location = new System.Drawing.Point(82, 583);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(233, 41);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.Text = "MY INFO";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnCarrier
            // 
            this.btnCarrier.BackColor = System.Drawing.Color.LightBlue;
            this.btnCarrier.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrier.Location = new System.Drawing.Point(82, 170);
            this.btnCarrier.Name = "btnCarrier";
            this.btnCarrier.Size = new System.Drawing.Size(233, 41);
            this.btnCarrier.TabIndex = 2;
            this.btnCarrier.Text = "ADD CARRIER";
            this.btnCarrier.UseVisualStyleBackColor = false;
            this.btnCarrier.Click += new System.EventHandler(this.btnCarrier_Click);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.Color.LightBlue;
            this.btnShipment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipment.ForeColor = System.Drawing.Color.Black;
            this.btnShipment.Location = new System.Drawing.Point(82, 87);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.Size = new System.Drawing.Size(233, 41);
            this.btnShipment.TabIndex = 1;
            this.btnShipment.Text = "SHIPMENT";
            this.btnShipment.UseVisualStyleBackColor = false;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Romantic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(3, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(148, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pnlEmp
            // 
            this.pnlEmp.BackColor = System.Drawing.Color.FloralWhite;
            this.pnlEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEmp.Location = new System.Drawing.Point(430, 3);
            this.pnlEmp.Name = "pnlEmp";
            this.pnlEmp.Size = new System.Drawing.Size(865, 690);
            this.pnlEmp.TabIndex = 1;
            // 
            // btnRoute
            // 
            this.btnRoute.BackColor = System.Drawing.Color.LightBlue;
            this.btnRoute.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoute.Location = new System.Drawing.Point(82, 247);
            this.btnRoute.Name = "btnRoute";
            this.btnRoute.Size = new System.Drawing.Size(233, 41);
            this.btnRoute.TabIndex = 5;
            this.btnRoute.Text = "ADD ROUTE";
            this.btnRoute.UseVisualStyleBackColor = false;
            this.btnRoute.Click += new System.EventHandler(this.btnRoute_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 696);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Employee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Employee_FormClosed);
            this.Load += new System.EventHandler(this.Employee_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEmp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Button btnCarrier;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnRoute;
    }
}