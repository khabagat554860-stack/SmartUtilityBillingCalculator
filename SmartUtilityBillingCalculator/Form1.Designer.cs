namespace SmartUtilityBillingCalculator
{
    partial class Form1
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
            lblAccountName = new Label();
            txtAccountName = new TextBox();
            lblMeterReadings = new TextBox();
            txtMeterReadings = new TextBox();
            btnProcessBilling = new Button();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // lblAccountName
            // 
            lblAccountName.AutoSize = true;
            lblAccountName.BackColor = Color.LightGray;
            lblAccountName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccountName.Location = new Point(45, 51);
            lblAccountName.Name = "lblAccountName";
            lblAccountName.Size = new Size(169, 30);
            lblAccountName.TabIndex = 0;
            lblAccountName.Text = "Customer Name";
            // 
            // txtAccountName
            // 
            txtAccountName.BackColor = SystemColors.GrayText;
            txtAccountName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAccountName.ForeColor = SystemColors.Info;
            txtAccountName.Location = new Point(261, 51);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(248, 27);
            txtAccountName.TabIndex = 1;
            // 
            // lblMeterReadings
            // 
            lblMeterReadings.BackColor = Color.LightGray;
            lblMeterReadings.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMeterReadings.Location = new Point(45, 103);
            lblMeterReadings.Name = "lblMeterReadings";
            lblMeterReadings.Size = new Size(169, 35);
            lblMeterReadings.TabIndex = 2;
            lblMeterReadings.Text = "Meter Readings";
            // 
            // txtMeterReadings
            // 
            txtMeterReadings.BackColor = SystemColors.GrayText;
            txtMeterReadings.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMeterReadings.ForeColor = SystemColors.Info;
            txtMeterReadings.Location = new Point(261, 111);
            txtMeterReadings.Name = "txtMeterReadings";
            txtMeterReadings.Size = new Size(248, 27);
            txtMeterReadings.TabIndex = 3;
            // 
            // btnProcessBilling
            // 
            btnProcessBilling.BackColor = Color.LightGray;
            btnProcessBilling.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcessBilling.Location = new Point(45, 180);
            btnProcessBilling.Name = "btnProcessBilling";
            btnProcessBilling.Size = new Size(169, 39);
            btnProcessBilling.TabIndex = 4;
            btnProcessBilling.Text = "Process Billing";
            btnProcessBilling.UseVisualStyleBackColor = false;
            btnProcessBilling.Click += btnProcessBilling_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.BackColor = SystemColors.Window;
            rtbOutput.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtbOutput.Location = new Point(238, 180);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(310, 157);
            rtbOutput.TabIndex = 5;
            rtbOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(576, 450);
            Controls.Add(rtbOutput);
            Controls.Add(btnProcessBilling);
            Controls.Add(txtMeterReadings);
            Controls.Add(lblMeterReadings);
            Controls.Add(txtAccountName);
            Controls.Add(lblAccountName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAccountName;
        private TextBox txtAccountName;
        private TextBox lblMeterReadings;
        private TextBox txtMeterReadings;
        private Button btnProcessBilling;
        private RichTextBox rtbOutput;
    }
}
