namespace LOGIN
{
    partial class Seller
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.txtIdSeller = new System.Windows.Forms.TextBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblGood = new System.Windows.Forms.Label();
            this.lblIdShipment = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSeller = new System.Windows.Forms.DataGridView();
            this.dgvShipmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrackingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTypeOfGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPickUpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRouteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.lblRecerver = new System.Windows.Forms.Label();
            this.txtREmail = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 523F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1287, 718);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Linen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtRName);
            this.panel4.Controls.Add(this.lblRecerver);
            this.panel4.Controls.Add(this.txtREmail);
            this.panel4.Controls.Add(this.txtGoods);
            this.panel4.Controls.Add(this.txtIdSeller);
            this.panel4.Controls.Add(this.cmbDestination);
            this.panel4.Controls.Add(this.lblDestination);
            this.panel4.Controls.Add(this.cmbOrigin);
            this.panel4.Controls.Add(this.lblPickUp);
            this.panel4.Controls.Add(this.lblVolume);
            this.panel4.Controls.Add(this.txtVolume);
            this.panel4.Controls.Add(this.lblWeight);
            this.panel4.Controls.Add(this.txtWeight);
            this.panel4.Controls.Add(this.lblGood);
            this.panel4.Controls.Add(this.lblIdShipment);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(517, 672);
            this.panel4.TabIndex = 3;
            // 
            // txtGoods
            // 
            this.txtGoods.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoods.Location = new System.Drawing.Point(203, 104);
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(293, 30);
            this.txtGoods.TabIndex = 15;
            this.txtGoods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGoods_KeyDown);
            // 
            // txtIdSeller
            // 
            this.txtIdSeller.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtIdSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSeller.ForeColor = System.Drawing.Color.IndianRed;
            this.txtIdSeller.Location = new System.Drawing.Point(206, 45);
            this.txtIdSeller.Name = "txtIdSeller";
            this.txtIdSeller.ReadOnly = true;
            this.txtIdSeller.Size = new System.Drawing.Size(292, 30);
            this.txtIdSeller.TabIndex = 14;
            this.txtIdSeller.Text = "Auto Generated";
            this.txtIdSeller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbDestination
            // 
            this.cmbDestination.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(203, 409);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(291, 24);
            this.cmbDestination.TabIndex = 12;
            this.cmbDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDestination_KeyDown);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(90, 409);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 25);
            this.lblDestination.TabIndex = 11;
            this.lblDestination.Text = "Drop-Off:";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(203, 362);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(291, 24);
            this.cmbOrigin.TabIndex = 10;
            this.cmbOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrigin_KeyDown);
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickUp.Location = new System.Drawing.Point(97, 362);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(95, 25);
            this.lblPickUp.TabIndex = 9;
            this.lblPickUp.Text = "Pick-Up:";
            this.lblPickUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(100, 203);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(92, 25);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume:";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVolume
            // 
            this.txtVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(206, 203);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(292, 30);
            this.txtVolume.TabIndex = 6;
            this.txtVolume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVolume_KeyDown);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(105, 154);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(87, 25);
            this.lblWeight.TabIndex = 5;
            this.lblWeight.Text = "Weight:";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(205, 154);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(293, 30);
            this.txtWeight.TabIndex = 3;
            this.txtWeight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWeight_KeyDown);
            // 
            // lblGood
            // 
            this.lblGood.AutoSize = true;
            this.lblGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGood.Location = new System.Drawing.Point(31, 104);
            this.lblGood.Name = "lblGood";
            this.lblGood.Size = new System.Drawing.Size(161, 25);
            this.lblGood.TabIndex = 2;
            this.lblGood.Text = "Type of Goods:";
            this.lblGood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdShipment
            // 
            this.lblIdShipment.AutoSize = true;
            this.lblIdShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdShipment.Location = new System.Drawing.Point(55, 45);
            this.lblIdShipment.Name = "lblIdShipment";
            this.lblIdShipment.Size = new System.Drawing.Size(137, 25);
            this.lblIdShipment.TabIndex = 0;
            this.lblIdShipment.Text = "Shipment ID:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(526, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 34);
            this.panel3.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(642, 32);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.IndianRed;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(642, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 32);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Bisque;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(234, 32);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Coral;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(240, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(275, 32);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvSeller);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(526, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 672);
            this.panel1.TabIndex = 0;
            // 
            // dgvSeller
            // 
            this.dgvSeller.AllowUserToAddRows = false;
            this.dgvSeller.AllowUserToDeleteRows = false;
            this.dgvSeller.BackgroundColor = System.Drawing.Color.Beige;
            this.dgvSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeller.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvShipmentId,
            this.dgvPaymentStatus,
            this.dgvTrackingStatus,
            this.dgvTypeOfGoods,
            this.dgvWeight,
            this.dgvVolume,
            this.dgvPickUpAddress,
            this.dgvDestination,
            this.dgvRouteId});
            this.dgvSeller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSeller.Location = new System.Drawing.Point(0, 0);
            this.dgvSeller.Name = "dgvSeller";
            this.dgvSeller.ReadOnly = true;
            this.dgvSeller.RowHeadersWidth = 51;
            this.dgvSeller.RowTemplate.Height = 24;
            this.dgvSeller.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSeller.Size = new System.Drawing.Size(756, 670);
            this.dgvSeller.TabIndex = 0;
            this.dgvSeller.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSeller_CellDoubleClick);
            // 
            // dgvShipmentId
            // 
            this.dgvShipmentId.DataPropertyName = "ShipmentID";
            this.dgvShipmentId.HeaderText = "SHIPMENT ID";
            this.dgvShipmentId.MinimumWidth = 6;
            this.dgvShipmentId.Name = "dgvShipmentId";
            this.dgvShipmentId.ReadOnly = true;
            this.dgvShipmentId.Width = 90;
            // 
            // dgvPaymentStatus
            // 
            this.dgvPaymentStatus.DataPropertyName = "PaymentStatus";
            this.dgvPaymentStatus.HeaderText = "PAYMENT STATUS";
            this.dgvPaymentStatus.MinimumWidth = 6;
            this.dgvPaymentStatus.Name = "dgvPaymentStatus";
            this.dgvPaymentStatus.ReadOnly = true;
            this.dgvPaymentStatus.Width = 120;
            // 
            // dgvTrackingStatus
            // 
            this.dgvTrackingStatus.DataPropertyName = "TrackingStatus";
            this.dgvTrackingStatus.HeaderText = "TRACKING STATUS";
            this.dgvTrackingStatus.MinimumWidth = 6;
            this.dgvTrackingStatus.Name = "dgvTrackingStatus";
            this.dgvTrackingStatus.ReadOnly = true;
            this.dgvTrackingStatus.Width = 125;
            // 
            // dgvTypeOfGoods
            // 
            this.dgvTypeOfGoods.DataPropertyName = "TypeOfGoods";
            this.dgvTypeOfGoods.HeaderText = "TYPE OF GOODS";
            this.dgvTypeOfGoods.MinimumWidth = 6;
            this.dgvTypeOfGoods.Name = "dgvTypeOfGoods";
            this.dgvTypeOfGoods.ReadOnly = true;
            this.dgvTypeOfGoods.Width = 120;
            // 
            // dgvWeight
            // 
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
            this.dgvVolume.Width = 90;
            // 
            // dgvPickUpAddress
            // 
            this.dgvPickUpAddress.DataPropertyName = "PickUpAddress";
            this.dgvPickUpAddress.HeaderText = "PICK-UP";
            this.dgvPickUpAddress.MinimumWidth = 6;
            this.dgvPickUpAddress.Name = "dgvPickUpAddress";
            this.dgvPickUpAddress.ReadOnly = true;
            this.dgvPickUpAddress.Width = 110;
            // 
            // dgvDestination
            // 
            this.dgvDestination.DataPropertyName = "Destination";
            this.dgvDestination.HeaderText = "DROP-OFF";
            this.dgvDestination.MinimumWidth = 6;
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.Width = 90;
            // 
            // dgvRouteId
            // 
            this.dgvRouteId.DataPropertyName = "RouteId";
            this.dgvRouteId.HeaderText = "ROUTE ID";
            this.dgvRouteId.MinimumWidth = 6;
            this.dgvRouteId.Name = "dgvRouteId";
            this.dgvRouteId.ReadOnly = true;
            this.dgvRouteId.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Receiver Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRName
            // 
            this.txtRName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRName.Location = new System.Drawing.Point(207, 305);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(292, 30);
            this.txtRName.TabIndex = 18;
            // 
            // lblRecerver
            // 
            this.lblRecerver.AutoSize = true;
            this.lblRecerver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecerver.Location = new System.Drawing.Point(42, 259);
            this.lblRecerver.Name = "lblRecerver";
            this.lblRecerver.Size = new System.Drawing.Size(150, 25);
            this.lblRecerver.TabIndex = 17;
            this.lblRecerver.Text = "Rceiver Email:";
            this.lblRecerver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtREmail
            // 
            this.txtREmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtREmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtREmail.Location = new System.Drawing.Point(206, 256);
            this.txtREmail.Name = "txtREmail";
            this.txtREmail.Size = new System.Drawing.Size(293, 30);
            this.txtREmail.TabIndex = 16;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 718);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Seller";
            this.Text = "Seller";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Seller_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblIdShipment;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblGood;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.DataGridView dgvSeller;
        private System.Windows.Forms.TextBox txtIdSeller;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvShipmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPaymentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrackingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTypeOfGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPickUpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRouteId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.Label lblRecerver;
        private System.Windows.Forms.TextBox txtREmail;
    }
}