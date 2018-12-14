namespace BillingTestForm
{
    partial class StartForm
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
            this.btnTestBillings = new System.Windows.Forms.Button();
            this.btnTestAgreement = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestBillings
            // 
            this.btnTestBillings.Location = new System.Drawing.Point(175, 21);
            this.btnTestBillings.Name = "btnTestBillings";
            this.btnTestBillings.Size = new System.Drawing.Size(168, 54);
            this.btnTestBillings.TabIndex = 0;
            this.btnTestBillings.Text = "Тестирование видов оплаты";
            this.btnTestBillings.UseVisualStyleBackColor = true;
            this.btnTestBillings.Click += new System.EventHandler(this.btnTestBillings_Click);
            // 
            // btnTestAgreement
            // 
            this.btnTestAgreement.Location = new System.Drawing.Point(175, 81);
            this.btnTestAgreement.Name = "btnTestAgreement";
            this.btnTestAgreement.Size = new System.Drawing.Size(168, 52);
            this.btnTestAgreement.TabIndex = 0;
            this.btnTestAgreement.Text = "Договора";
            this.btnTestAgreement.UseVisualStyleBackColor = true;
            this.btnTestAgreement.Click += new System.EventHandler(this.btnTestAgreement_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 415);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTestAgreement);
            this.Controls.Add(this.btnTestBillings);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestBillings;
        private System.Windows.Forms.Button btnTestAgreement;
        private System.Windows.Forms.Button btnClose;
    }
}