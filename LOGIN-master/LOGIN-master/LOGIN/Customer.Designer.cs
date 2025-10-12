namespace LOGIN
{
    partial class Customer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.dgvShipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeOfGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrackingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPickUpAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefreshC = new System.Windows.Forms.Button();
            this.txtSearchC = new System.Windows.Forms.TextBox();
            this.btnSearchC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1556, 747);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvCustomer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 691);
            this.panel2.TabIndex = 1;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvShipmentId,
            this.dgvTypeOfGood,
            this.dgvTrackingStatus,
            this.dgvWeight,
            this.dgvVolume,
            this.dgvPickUpAdress,
            this.dgvDestination,
            this.dgvEDT,
            this.PaymentStatus});
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1546, 687);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // dgvShipmentId
            // 
            this.dgvShipmentId.DataPropertyName = "ShipmentId";
            this.dgvShipmentId.HeaderText = "SHIPMENT ID";
            this.dgvShipmentId.MinimumWidth = 6;
            this.dgvShipmentId.Name = "dgvShipmentId";
            this.dgvShipmentId.ReadOnly = true;
            this.dgvShipmentId.Width = 120;
            // 
            // dgvTypeOfGood
            // 
            this.dgvTypeOfGood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTypeOfGood.DataPropertyName = "TypeOfGoods";
            this.dgvTypeOfGood.HeaderText = "PRODUCT TYPE";
            this.dgvTypeOfGood.MinimumWidth = 6;
            this.dgvTypeOfGood.Name = "dgvTypeOfGood";
            this.dgvTypeOfGood.ReadOnly = true;
            this.dgvTypeOfGood.Width = 130;
            // 
            // dgvTrackingStatus
            // 
            this.dgvTrackingStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvTrackingStatus.DataPropertyName = "TrackingStatus";
            this.dgvTrackingStatus.HeaderText = "TRACKING STATUS";
            this.dgvTrackingStatus.MinimumWidth = 6;
            this.dgvTrackingStatus.Name = "dgvTrackingStatus";
            this.dgvTrackingStatus.ReadOnly = true;
            this.dgvTrackingStatus.Width = 148;
            // 
            // dgvWeight
            // 
            this.dgvWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgvWeight.DataPropertyName = "Weight";
            this.dgvWeight.HeaderText = "WEIGHT";
            this.dgvWeight.MinimumWidth = 6;
            this.dgvWeight.Name = "dgvWeight";
            this.dgvWeight.ReadOnly = true;
            this.dgvWeight.Width = 90;
            // 
            // dgvVolume
            // 
            this.dgvVolume.DataPropertyName = "Volume";
            this.dgvVolume.HeaderText = "VOLUME";
            this.dgvVolume.MinimumWidth = 6;
            this.dgvVolume.Name = "dgvVolume";
            this.dgvVolume.ReadOnly = true;
            this.dgvVolume.Width = 125;
            // 
            // dgvPickUpAdress
            // 
            this.dgvPickUpAdress.DataPropertyName = "PickUpAddress";
            this.dgvPickUpAdress.HeaderText = "PICK-UP";
            this.dgvPickUpAdress.MinimumWidth = 6;
            this.dgvPickUpAdress.Name = "dgvPickUpAdress";
            this.dgvPickUpAdress.ReadOnly = true;
            this.dgvPickUpAdress.Width = 90;
            // 
            // dgvDestination
            // 
            this.dgvDestination.DataPropertyName = "Destination";
            this.dgvDestination.HeaderText = "DROP-OFF";
            this.dgvDestination.MinimumWidth = 6;
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.Width = 125;
            // 
            // dgvEDT
            // 
            this.dgvEDT.DataPropertyName = "EstimatedDeliveryTime";
            this.dgvEDT.HeaderText = "EST. DELIVERY TIME";
            this.dgvEDT.MinimumWidth = 6;
            this.dgvEDT.Name = "dgvEDT";
            this.dgvEDT.ReadOnly = true;
            this.dgvEDT.Width = 125;
            // 
            // PaymentStatus
            // 
            this.PaymentStatus.HeaderText = "PAYMENT STATUS";
            this.PaymentStatus.MinimumWidth = 6;
            this.PaymentStatus.Name = "PaymentStatus";
            this.PaymentStatus.ReadOnly = true;
            this.PaymentStatus.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRefreshC);
            this.panel1.Controls.Add(this.txtSearchC);
            this.panel1.Controls.Add(this.btnSearchC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 44);
            this.panel1.TabIndex = 0;
            // 
            // btnRefreshC
            // 
            this.btnRefreshC.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnRefreshC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshC.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshC.Name = "btnRefreshC";
            this.btnRefreshC.Size = new System.Drawing.Size(207, 40);
            this.btnRefreshC.TabIndex = 2;
            this.btnRefreshC.Text = "REFRESH";
            this.btnRefreshC.UseVisualStyleBackColor = false;
            this.btnRefreshC.Click += new System.EventHandler(this.btnRefreshC_Click);
            // 
            // txtSearchC
            // 
            this.txtSearchC.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearchC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchC.Location = new System.Drawing.Point(213, 2);
            this.txtSearchC.Multiline = true;
            this.txtSearchC.Name = "txtSearchC";
            this.txtSearchC.Size = new System.Drawing.Size(1064, 38);
            this.txtSearchC.TabIndex = 1;
            // 
            // btnSearchC
            // 
            this.btnSearchC.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearchC.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearchC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchC.Location = new System.Drawing.Point(1250, 0);
            this.btnSearchC.Name = "btnSearchC";
            this.btnSearchC.Size = new System.Drawing.Size(296, 40);
            this.btnSearchC.TabIndex = 0;
            this.btnSearchC.Text = "SEARCH";
            this.btnSearchC.UseVisualStyleBackColor = false;
            this.btnSearchC.Click += new System.EventHandler(this.btnSearchC_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 747);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnSearchC;
        private System.Windows.Forms.TextBox txtSearchC;
        private System.Windows.Forms.Button btnRefreshC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeOfGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrackingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPickUpAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentStatus;
    }
}