namespace BookingSystem1
{
    partial class Cfrmbooking
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
            this.grpbBokking = new System.Windows.Forms.GroupBox();
            this.radOneway = new System.Windows.Forms.RadioButton();
            this.radReturn = new System.Windows.Forms.RadioButton();
            this.lblClass = new System.Windows.Forms.Label();
            this.llblPassengers = new System.Windows.Forms.Label();
            this.lblDepature = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.nudPass = new System.Windows.Forms.NumericUpDown();
            this.dtpDepature = new System.Windows.Forms.DateTimePicker();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.btnQuote = new System.Windows.Forms.Button();
            this.grpbBokking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbBokking
            // 
            this.grpbBokking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbBokking.Controls.Add(this.radOneway);
            this.grpbBokking.Controls.Add(this.radReturn);
            this.grpbBokking.Location = new System.Drawing.Point(9, 17);
            this.grpbBokking.Name = "grpbBokking";
            this.grpbBokking.Size = new System.Drawing.Size(477, 83);
            this.grpbBokking.TabIndex = 0;
            this.grpbBokking.TabStop = false;
            this.grpbBokking.Text = "Booking Type";
            // 
            // radOneway
            // 
            this.radOneway.AutoSize = true;
            this.radOneway.Location = new System.Drawing.Point(272, 32);
            this.radOneway.Name = "radOneway";
            this.radOneway.Size = new System.Drawing.Size(91, 17);
            this.radOneway.TabIndex = 1;
            this.radOneway.TabStop = true;
            this.radOneway.Text = "One Way Trip";
            this.radOneway.UseVisualStyleBackColor = true;
            // 
            // radReturn
            // 
            this.radReturn.AutoSize = true;
            this.radReturn.Location = new System.Drawing.Point(29, 32);
            this.radReturn.Name = "radReturn";
            this.radReturn.Size = new System.Drawing.Size(78, 17);
            this.radReturn.TabIndex = 0;
            this.radReturn.TabStop = true;
            this.radReturn.Text = "Return Trip";
            this.radReturn.UseVisualStyleBackColor = true;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(41, 142);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class";
            // 
            // llblPassengers
            // 
            this.llblPassengers.AutoSize = true;
            this.llblPassengers.Location = new System.Drawing.Point(41, 197);
            this.llblPassengers.Name = "llblPassengers";
            this.llblPassengers.Size = new System.Drawing.Size(62, 13);
            this.llblPassengers.TabIndex = 2;
            this.llblPassengers.Text = "Passengers";
            // 
            // lblDepature
            // 
            this.lblDepature.AutoSize = true;
            this.lblDepature.Location = new System.Drawing.Point(41, 249);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(51, 13);
            this.lblDepature.TabIndex = 3;
            this.lblDepature.Text = "Depature";
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(41, 299);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(39, 13);
            this.lblReturn.TabIndex = 4;
            this.lblReturn.Text = "Return";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "First",
            "Business",
            "Economy"});
            this.cmbClass.Location = new System.Drawing.Point(116, 142);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(153, 21);
            this.cmbClass.TabIndex = 5;
            // 
            // nudPass
            // 
            this.nudPass.Location = new System.Drawing.Point(201, 195);
            this.nudPass.Name = "nudPass";
            this.nudPass.Size = new System.Drawing.Size(46, 20);
            this.nudPass.TabIndex = 6;
            // 
            // dtpDepature
            // 
            this.dtpDepature.CustomFormat = "";
            this.dtpDepature.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepature.Location = new System.Drawing.Point(201, 249);
            this.dtpDepature.Name = "dtpDepature";
            this.dtpDepature.Size = new System.Drawing.Size(200, 20);
            this.dtpDepature.TabIndex = 7;
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturn.Location = new System.Drawing.Point(201, 299);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 20);
            this.dtpReturn.TabIndex = 8;
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(9, 396);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(94, 23);
            this.btnQuote.TabIndex = 9;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // Cfrmbooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 441);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpDepature);
            this.Controls.Add(this.nudPass);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblDepature);
            this.Controls.Add(this.llblPassengers);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.grpbBokking);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cfrmbooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline Booking System";
            this.grpbBokking.ResumeLayout(false);
            this.grpbBokking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbBokking;
        private System.Windows.Forms.RadioButton radOneway;
        private System.Windows.Forms.RadioButton radReturn;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label llblPassengers;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.NumericUpDown nudPass;
        private System.Windows.Forms.DateTimePicker dtpDepature;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Button btnQuote;
    }
}

