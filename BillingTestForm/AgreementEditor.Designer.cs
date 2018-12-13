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
            this.txtBilling = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSetBilling = new System.Windows.Forms.Button();
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
            billingLabel.Size = new System.Drawing.Size(47, 13);
            billingLabel.TabIndex = 1;
            billingLabel.Text = "Оплата:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(36, 17);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 3;
            dateLabel.Text = "Дата:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(36, 42);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(44, 13);
            numberLabel.TabIndex = 7;
            numberLabel.Text = "Номер:";
            // 
            // txtBilling
            // 
            this.txtBilling.Location = new System.Drawing.Point(89, 65);
            this.txtBilling.Name = "txtBilling";
            this.txtBilling.Size = new System.Drawing.Size(200, 20);
            this.txtBilling.TabIndex = 2;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(89, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(89, 39);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(192, 151);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSetBilling
            // 
            this.btnSetBilling.Location = new System.Drawing.Point(295, 63);
            this.btnSetBilling.Name = "btnSetBilling";
            this.btnSetBilling.Size = new System.Drawing.Size(75, 23);
            this.btnSetBilling.TabIndex = 11;
            this.btnSetBilling.Text = "Настроить";
            this.btnSetBilling.UseVisualStyleBackColor = true;
            this.btnSetBilling.Click += new System.EventHandler(this.btnSetBilling_Click);
            // 
            // AgreementEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 194);
            this.Controls.Add(this.btnSetBilling);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(billingLabel);
            this.Controls.Add(this.txtBilling);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.txtNumber);
            this.Name = "AgreementEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AgreementEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBilling;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSetBilling;
    }
}