namespace LOGIN
{
    partial class Shipment
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSecond = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtVol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.txtPickUP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.txtEst = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCarrier = new System.Windows.Forms.ComboBox();
            this.cmbTrackingStatus = new System.Windows.Forms.ComboBox();
            this.lblRouteId = new System.Windows.Forms.Label();
            this.txtRouteId = new System.Windows.Forms.TextBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            this.tlpSecond.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpSecond, 0, 1);
            this.tlpMain.Controls.Add(this.panel1, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1302, 715);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpSecond
            // 
            this.tlpSecond.ColumnCount = 2;
            this.tlpSecond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 508F));
            this.tlpSecond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecond.Controls.Add(this.pnlRight, 1, 0);
            this.tlpSecond.Controls.Add(this.pnlLeft, 0, 0);
            this.tlpSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSecond.Location = new System.Drawing.Point(3, 53);
            this.tlpSecond.Name = "tlpSecond";
            this.tlpSecond.RowCount = 1;
            this.tlpSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSecond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 659F));
            this.tlpSecond.Size = new System.Drawing.Size(1296, 659);
            this.tlpSecond.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.dgvEmployee);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(511, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(782, 653);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployee.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(778, 649);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 44);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(508, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 40);
            this.panel3.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(603, 40);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Brown;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(603, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnPayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 40);
            this.panel2.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(255, 0);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 36);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(371, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPayment.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(0, 0);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 36);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(228, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(242, 34);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "Auto Generated";
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shipment ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tracking Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Types Of Goods:";
            // 
            // txtGoods
            // 
            this.txtGoods.BackColor = System.Drawing.Color.White;
            this.txtGoods.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoods.Location = new System.Drawing.Point(228, 159);
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.ReadOnly = true;
            this.txtGoods.Size = new System.Drawing.Size(242, 34);
            this.txtGoods.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weight:";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.Color.White;
            this.txtWeight.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(228, 213);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(242, 34);
            this.txtWeight.TabIndex = 8;
            // 
            // txtVol
            // 
            this.txtVol.BackColor = System.Drawing.Color.White;
            this.txtVol.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVol.Location = new System.Drawing.Point(228, 257);
            this.txtVol.Name = "txtVol";
            this.txtVol.ReadOnly = true;
            this.txtVol.Size = new System.Drawing.Size(242, 34);
            this.txtVol.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Volume:";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.Location = new System.Drawing.Point(113, 310);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(107, 25);
            this.la.TabIndex = 11;
            this.la.Text = "Pick-Up :";
            // 
            // txtPickUP
            // 
            this.txtPickUP.BackColor = System.Drawing.Color.White;
            this.txtPickUP.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPickUP.Location = new System.Drawing.Point(228, 310);
            this.txtPickUP.Name = "txtPickUP";
            this.txtPickUP.ReadOnly = true;
            this.txtPickUP.Size = new System.Drawing.Size(242, 34);
            this.txtPickUP.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Drop-Off:";
            // 
            // txtDestination
            // 
            this.txtDestination.BackColor = System.Drawing.Color.White;
            this.txtDestination.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(228, 360);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.ReadOnly = true;
            this.txtDestination.Size = new System.Drawing.Size(242, 34);
            this.txtDestination.TabIndex = 14;
            // 
            // txtEst
            // 
            this.txtEst.AutoSize = true;
            this.txtEst.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEst.Location = new System.Drawing.Point(63, 421);
            this.txtEst.Name = "txtEst";
            this.txtEst.Size = new System.Drawing.Size(157, 25);
            this.txtEst.TabIndex = 15;
            this.txtEst.Text = "Est. Del. Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Client ID:";
            // 
            // txtClient
            // 
            this.txtClient.BackColor = System.Drawing.Color.White;
            this.txtClient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClient.Location = new System.Drawing.Point(228, 66);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(242, 34);
            this.txtClient.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(228, 421);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 27);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(119, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Carrier :";
            // 
            // cmbCarrier
            // 
            this.cmbCarrier.BackColor = System.Drawing.Color.BurlyWood;
            this.cmbCarrier.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCarrier.FormattingEnabled = true;
            this.cmbCarrier.Location = new System.Drawing.Point(228, 461);
            this.cmbCarrier.Name = "cmbCarrier";
            this.cmbCarrier.Size = new System.Drawing.Size(242, 33);
            this.cmbCarrier.TabIndex = 27;
            this.cmbCarrier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCarrier_KeyDown);
            // 
            // cmbTrackingStatus
            // 
            this.cmbTrackingStatus.BackColor = System.Drawing.Color.BurlyWood;
            this.cmbTrackingStatus.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrackingStatus.FormattingEnabled = true;
            this.cmbTrackingStatus.Items.AddRange(new object[] {
            "Pending",
            "Shiped",
            "In Transit",
            "Delivered",
            "Cancelled"});
            this.cmbTrackingStatus.Location = new System.Drawing.Point(228, 504);
            this.cmbTrackingStatus.Name = "cmbTrackingStatus";
            this.cmbTrackingStatus.Size = new System.Drawing.Size(242, 33);
            this.cmbTrackingStatus.TabIndex = 28;
            this.cmbTrackingStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTrackingStatus_KeyDown);
            // 
            // lblRouteId
            // 
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouteId.Location = new System.Drawing.Point(107, 113);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(113, 25);
            this.lblRouteId.TabIndex = 30;
            this.lblRouteId.Text = "Route ID:";
            // 
            // txtRouteId
            // 
            this.txtRouteId.BackColor = System.Drawing.Color.White;
            this.txtRouteId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRouteId.Location = new System.Drawing.Point(228, 113);
            this.txtRouteId.Name = "txtRouteId";
            this.txtRouteId.ReadOnly = true;
            this.txtRouteId.Size = new System.Drawing.Size(242, 34);
            this.txtRouteId.TabIndex = 31;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLeft.Controls.Add(this.txtRouteId);
            this.pnlLeft.Controls.Add(this.lblRouteId);
            this.pnlLeft.Controls.Add(this.cmbTrackingStatus);
            this.pnlLeft.Controls.Add(this.cmbCarrier);
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.dateTimePicker1);
            this.pnlLeft.Controls.Add(this.txtClient);
            this.pnlLeft.Controls.Add(this.label9);
            this.pnlLeft.Controls.Add(this.txtEst);
            this.pnlLeft.Controls.Add(this.txtDestination);
            this.pnlLeft.Controls.Add(this.label6);
            this.pnlLeft.Controls.Add(this.txtPickUP);
            this.pnlLeft.Controls.Add(this.la);
            this.pnlLeft.Controls.Add(this.label8);
            this.pnlLeft.Controls.Add(this.txtVol);
            this.pnlLeft.Controls.Add(this.txtWeight);
            this.pnlLeft.Controls.Add(this.label4);
            this.pnlLeft.Controls.Add(this.txtGoods);
            this.pnlLeft.Controls.Add(this.label3);
            this.pnlLeft.Controls.Add(this.label2);
            this.pnlLeft.Controls.Add(this.label1);
            this.pnlLeft.Controls.Add(this.txtId);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(502, 653);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(127, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "CONFIRM";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Shipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 715);
            this.Controls.Add(this.tlpMain);
            this.Name = "Shipment";
            this.Text = "Shipment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Shipment_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpSecond.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpSecond;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.TextBox txtRouteId;
        private System.Windows.Forms.Label lblRouteId;
        private System.Windows.Forms.ComboBox cmbTrackingStatus;
        private System.Windows.Forms.ComboBox cmbCarrier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtEst;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPickUP;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVol;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnUpdate;
    }
}