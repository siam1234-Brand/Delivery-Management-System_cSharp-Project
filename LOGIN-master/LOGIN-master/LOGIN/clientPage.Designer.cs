namespace LOGIN
{
    partial class clientPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientPage));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowC = new System.Windows.Forms.Button();
            this.btnAccountUp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShipment = new System.Windows.Forms.Button();
            this.cmbClientType = new System.Windows.Forms.ComboBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 493F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1146, 707);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnShowC);
            this.panel1.Controls.Add(this.btnAccountUp);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnShipment);
            this.panel1.Controls.Add(this.cmbClientType);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(487, 701);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(62, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 49);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE ACCOUNT";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowC
            // 
            this.btnShowC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnShowC.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowC.Location = new System.Drawing.Point(61, 213);
            this.btnShowC.Name = "btnShowC";
            this.btnShowC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowC.Size = new System.Drawing.Size(288, 47);
            this.btnShowC.TabIndex = 7;
            this.btnShowC.Text = "SHOW DETAILS";
            this.btnShowC.UseVisualStyleBackColor = false;
            this.btnShowC.Visible = false;
            this.btnShowC.Click += new System.EventHandler(this.btnShowC_Click);
            // 
            // btnAccountUp
            // 
            this.btnAccountUp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAccountUp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountUp.Location = new System.Drawing.Point(61, 302);
            this.btnAccountUp.Name = "btnAccountUp";
            this.btnAccountUp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccountUp.Size = new System.Drawing.Size(288, 47);
            this.btnAccountUp.TabIndex = 6;
            this.btnAccountUp.Text = "UPDATE ACCOUNT";
            this.btnAccountUp.UseVisualStyleBackColor = false;
            this.btnAccountUp.Click += new System.EventHandler(this.btnAccountUp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Coral;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(117, 484);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(185, 50);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // btnShipment
            // 
            this.btnShipment.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnShipment.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipment.Location = new System.Drawing.Point(86, 213);
            this.btnShipment.Name = "btnShipment";
            this.btnShipment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShipment.Size = new System.Drawing.Size(263, 47);
            this.btnShipment.TabIndex = 2;
            this.btnShipment.Text = "ADD SHIPMENT";
            this.btnShipment.UseVisualStyleBackColor = false;
            this.btnShipment.Visible = false;
            this.btnShipment.Click += new System.EventHandler(this.btnShipment_Click);
            // 
            // cmbClientType
            // 
            this.cmbClientType.BackColor = System.Drawing.Color.LemonChiffon;
            this.cmbClientType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.Items.AddRange(new object[] {
            "Customer",
            "Seller"});
            this.cmbClientType.Location = new System.Drawing.Point(62, 146);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbClientType.Size = new System.Drawing.Size(287, 33);
            this.cmbClientType.TabIndex = 4;
            this.cmbClientType.Text = "SELECT  TYPE";
            this.cmbClientType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Romantic", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Azure;
            this.lblWelcome.Location = new System.Drawing.Point(9, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblWelcome.Size = new System.Drawing.Size(165, 45);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pnlClient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(496, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 701);
            this.panel2.TabIndex = 1;
            // 
            // pnlClient
            // 
            this.pnlClient.BackColor = System.Drawing.Color.Beige;
            this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClient.Location = new System.Drawing.Point(0, 0);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(647, 701);
            this.pnlClient.TabIndex = 0;
            // 
            // clientPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "clientPage";
            this.Text = "clientPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.clientPage_FormClosed);
            this.Load += new System.EventHandler(this.clientPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShipment;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbClientType;
        private System.Windows.Forms.Button btnAccountUp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.Button btnShowC;
        private System.Windows.Forms.Button btnDelete;
    }
}