namespace BillingTestForm
{
    partial class AgreementEditor
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
            System.Windows.Forms.Label billingLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label numberLabel;
            this.billingTextBox = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumber = new System.Windows.Forms.TextBox();
            billingLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // billingLabel
            // 
            billingLabel.AutoSize = true;
            billingLabel.Location = new System.Drawing.Point(36, 68);
            billingLabel.Name = "billingLabel";
            billingLabel.Size = new System.Drawing.Size(37, 13);
            billingLabel.TabIndex = 1;
            billingLabel.Text = "Billing:";
            // 
            // billingTextBox
            // 
            this.billingTextBox.Location = new System.Drawing.Point(89, 65);
            this.billingTextBox.Name = "billingTextBox";
            this.billingTextBox.Size = new System.Drawing.Size(200, 20);
            this.billingTextBox.TabIndex = 2;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(36, 17);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(33, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(89, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(36, 42);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(47, 13);
            numberLabel.TabIndex = 7;
            numberLabel.Text = "Number:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(89, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // AgreementEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(billingLabel);
            this.Controls.Add(this.billingTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.txtNumber);
            this.Name = "AgreementEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AgreementEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox billingTextBox;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNumber;
    }
}