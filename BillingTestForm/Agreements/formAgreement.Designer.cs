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
            this.btnClose = new System.Windows.Forms.Button();
            this.listAgreements = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listCompanies = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            this.listBills = new System.Windows.Forms.ListBox();
            this.lblBilling = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // listAgreements
            // 
            this.listAgreements.FormattingEnabled = true;
            this.listAgreements.Location = new System.Drawing.Point(6, 19);
            this.listAgreements.Name = "listAgreements";
            this.listAgreements.Size = new System.Drawing.Size(419, 95);
            this.listAgreements.TabIndex = 1;
            this.listAgreements.SelectedIndexChanged += new System.EventHandler(this.listAgreements_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(245, 120);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(164, 120);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(83, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listCompanies
            // 
            this.listCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCompanies.FormattingEnabled = true;
            this.listCompanies.Location = new System.Drawing.Point(12, 31);
            this.listCompanies.Name = "listCompanies";
            this.listCompanies.Size = new System.Drawing.Size(419, 21);
            this.listCompanies.TabIndex = 5;
            this.listCompanies.SelectedIndexChanged += new System.EventHandler(this.listCompanies_SelectedIndexChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(452, 227);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 7;
            this.result.Text = "label1";
            // 
            // listBills
            // 
            this.listBills.FormattingEnabled = true;
            this.listBills.Location = new System.Drawing.Point(20, 227);
            this.listBills.Name = "listBills";
            this.listBills.Size = new System.Drawing.Size(418, 134);
            this.listBills.TabIndex = 8;
            this.listBills.SelectedIndexChanged += new System.EventHandler(this.listBills_SelectedIndexChanged);
            // 
            // lblBilling
            // 
            this.lblBilling.AutoSize = true;
            this.lblBilling.Location = new System.Drawing.Point(452, 77);
            this.lblBilling.Name = "lblBilling";
            this.lblBilling.Size = new System.Drawing.Size(35, 13);
            this.lblBilling.TabIndex = 7;
            this.lblBilling.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listAgreements);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 150);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Договоры:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Счета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Организации:";
            // 
            // formAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBills);
            this.Controls.Add(this.lblBilling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.listCompanies);
            this.Controls.Add(this.btnClose);
            this.Name = "formAgreement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formAgreement";
            this.Load += new System.EventHandler(this.formAgreement_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listAgreements;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox listCompanies;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ListBox listBills;
        private System.Windows.Forms.Label lblBilling;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}