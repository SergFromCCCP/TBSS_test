namespace BillingTestForm
{
    partial class formAgreement
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
            this.button1 = new System.Windows.Forms.Button();
            this.listAgreements = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listCompanies = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.result = new System.Windows.Forms.Label();
            this.listBills = new System.Windows.Forms.ListBox();
            this.lblBilling = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listAgreements
            // 
            this.listAgreements.FormattingEnabled = true;
            this.listAgreements.Location = new System.Drawing.Point(12, 39);
            this.listAgreements.Name = "listAgreements";
            this.listAgreements.Size = new System.Drawing.Size(419, 95);
            this.listAgreements.TabIndex = 1;
            this.listAgreements.SelectedIndexChanged += new System.EventHandler(this.listAgreements_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(251, 140);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Delete";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(170, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(89, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listCompanies
            // 
            this.listCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCompanies.FormattingEnabled = true;
            this.listCompanies.Location = new System.Drawing.Point(12, 12);
            this.listCompanies.Name = "listCompanies";
            this.listCompanies.Size = new System.Drawing.Size(419, 21);
            this.listCompanies.TabIndex = 5;
            this.listCompanies.SelectedIndexChanged += new System.EventHandler(this.listCompanies_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(531, 332);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 6;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(465, 121);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 7;
            this.result.Text = "label1";
            // 
            // listBills
            // 
            this.listBills.FormattingEnabled = true;
            this.listBills.Location = new System.Drawing.Point(13, 189);
            this.listBills.Name = "listBills";
            this.listBills.Size = new System.Drawing.Size(418, 134);
            this.listBills.TabIndex = 8;
            this.listBills.SelectedIndexChanged += new System.EventHandler(this.listBills_SelectedIndexChanged);
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Location = new System.Drawing.Point(465, 39);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(35, 13);
            this.lblBilling.TabIndex = 7;
            this.lblBilling.Text = "label1";
            // 
            // formAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.lblBilling);
            this.Controls.Add(this.result);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.listCompanies);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listAgreements);
            this.Controls.Add(this.button1);
            this.Name = "formAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formAgreement";
            this.Load += new System.EventHandler(this.formAgreement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listAgreements;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox listCompanies;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ListBox listBills;
        private System.Windows.Forms.Label lblBilling;
    }
}