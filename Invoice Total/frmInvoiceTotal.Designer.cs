namespace Invoice_Total
{
    partial class frmInvoiceTotal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDaysDriven = new Label();
            txtDaysDriven = new TextBox();
            txtPricePerMile = new TextBox();
            txtTotalPrice = new TextBox();
            txtMilesDriven = new TextBox();
            txtPricePerDay = new TextBox();
            lblPricePerDay = new Label();
            lblMilesDriven = new Label();
            lblPricePerMile = new Label();
            lblTotalPrice = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblDaysDriven
            // 
            lblDaysDriven.BackColor = SystemColors.ActiveCaption;
            lblDaysDriven.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDaysDriven.Location = new Point(159, 82);
            lblDaysDriven.Name = "lblDaysDriven";
            lblDaysDriven.Size = new Size(114, 23);
            lblDaysDriven.TabIndex = 8;
            lblDaysDriven.Text = "Days Driven:";
            // 
            // txtDaysDriven
            // 
            txtDaysDriven.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDaysDriven.Location = new Point(451, 82);
            txtDaysDriven.Name = "txtDaysDriven";
            txtDaysDriven.Size = new Size(100, 26);
            txtDaysDriven.TabIndex = 0;
            // 
            // txtPricePerMile
            // 
            txtPricePerMile.BackColor = SystemColors.GradientInactiveCaption;
            txtPricePerMile.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPricePerMile.Location = new Point(451, 216);
            txtPricePerMile.Name = "txtPricePerMile";
            txtPricePerMile.ReadOnly = true;
            txtPricePerMile.Size = new Size(100, 26);
            txtPricePerMile.TabIndex = 6;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = SystemColors.GradientInactiveCaption;
            txtTotalPrice.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(451, 261);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(100, 26);
            txtTotalPrice.TabIndex = 7;
            // 
            // txtMilesDriven
            // 
            txtMilesDriven.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMilesDriven.Location = new Point(451, 173);
            txtMilesDriven.Name = "txtMilesDriven";
            txtMilesDriven.Size = new Size(100, 26);
            txtMilesDriven.TabIndex = 5;
            // 
            // txtPricePerDay
            // 
            txtPricePerDay.BackColor = SystemColors.GradientInactiveCaption;
            txtPricePerDay.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPricePerDay.Location = new Point(451, 125);
            txtPricePerDay.Name = "txtPricePerDay";
            txtPricePerDay.ReadOnly = true;
            txtPricePerDay.Size = new Size(100, 26);
            txtPricePerDay.TabIndex = 4;
            // 
            // lblPricePerDay
            // 
            lblPricePerDay.BackColor = SystemColors.ActiveCaption;
            lblPricePerDay.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPricePerDay.Location = new Point(159, 125);
            lblPricePerDay.Name = "lblPricePerDay";
            lblPricePerDay.Size = new Size(121, 23);
            lblPricePerDay.TabIndex = 9;
            lblPricePerDay.Text = "Price Per Day:";
            lblPricePerDay.Click += this.label2_Click;
            // 
            // lblMilesDriven
            // 
            lblMilesDriven.BackColor = SystemColors.ActiveCaption;
            lblMilesDriven.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMilesDriven.Location = new Point(159, 173);
            lblMilesDriven.Name = "lblMilesDriven";
            lblMilesDriven.Size = new Size(114, 23);
            lblMilesDriven.TabIndex = 10;
            lblMilesDriven.Text = "Miles Driven:";
            lblMilesDriven.Click += this.label3_Click;
            // 
            // lblPricePerMile
            // 
            lblPricePerMile.BackColor = SystemColors.ActiveCaption;
            lblPricePerMile.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPricePerMile.Location = new Point(159, 216);
            lblPricePerMile.Name = "lblPricePerMile";
            lblPricePerMile.Size = new Size(121, 23);
            lblPricePerMile.TabIndex = 11;
            lblPricePerMile.Text = "Price Per Mile:";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = SystemColors.ActiveCaption;
            lblTotalPrice.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPrice.Location = new Point(159, 261);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(100, 23);
            lblTotalPrice.TabIndex = 12;
            lblTotalPrice.Text = "Total Price:";
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(37, 373);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(131, 39);
            btnCalculate.TabIndex = 1;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(285, 373);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 39);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(510, 373);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(131, 39);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // frmInvoiceTotal
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblPricePerMile);
            Controls.Add(lblMilesDriven);
            Controls.Add(lblPricePerDay);
            Controls.Add(txtPricePerDay);
            Controls.Add(txtMilesDriven);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtPricePerMile);
            Controls.Add(txtDaysDriven);
            Controls.Add(lblDaysDriven);
            Name = "frmInvoiceTotal";
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDaysDriven;
        private TextBox txtDaysDriven;
        private TextBox txtPricePerMile;
        private TextBox txtTotalPrice;
        private TextBox txtMilesDriven;
        private TextBox txtPricePerDay;
        private Label lblPricePerDay;
        private Label lblMilesDriven;
        private Label lblPricePerMile;
        private Label lblTotalPrice;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
    }
}
