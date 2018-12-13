namespace BillingTestForm
{
    partial class BillingAfterIntervalEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.inpBillFirst = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.inpBillLast = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.inpPayFirst = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.inpPayLast = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inpBillFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBillLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPayFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPayLast)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата счета с:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inpBillFirst
            // 
            this.inpBillFirst.Location = new System.Drawing.Point(139, 20);
            this.inpBillFirst.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.inpBillFirst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpBillFirst.Name = "inpBillFirst";
            this.inpBillFirst.Size = new System.Drawing.Size(55, 20);
            this.inpBillFirst.TabIndex = 1;
            this.inpBillFirst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "по:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inpBillLast
            // 
            this.inpBillLast.Location = new System.Drawing.Point(231, 20);
            this.inpBillLast.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.inpBillLast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpBillLast.Name = "inpBillLast";
            this.inpBillLast.Size = new System.Drawing.Size(55, 20);
            this.inpBillLast.TabIndex = 1;
            this.inpBillLast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Дата оплаты счета с:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inpPayFirst
            // 
            this.inpPayFirst.Location = new System.Drawing.Point(139, 48);
            this.inpPayFirst.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.inpPayFirst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpPayFirst.Name = "inpPayFirst";
            this.inpPayFirst.Size = new System.Drawing.Size(55, 20);
            this.inpPayFirst.TabIndex = 1;
            this.inpPayFirst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "по:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inpPayLast
            // 
            this.inpPayLast.Location = new System.Drawing.Point(231, 48);
            this.inpPayLast.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.inpPayLast.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inpPayLast.Name = "inpPayLast";
            this.inpPayLast.Size = new System.Drawing.Size(55, 20);
            this.inpPayLast.TabIndex = 1;
            this.inpPayLast.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(47, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // BillingAfterIntervalEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(315, 148);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.inpPayLast);
            this.Controls.Add(this.inpBillLast);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inpPayFirst);
            this.Controls.Add(this.inpBillFirst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BillingAfterIntervalEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор интервалов оплаты";
            this.Load += new System.EventHandler(this.BillingAfterIntervalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inpBillFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpBillLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPayFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inpPayLast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inpBillFirst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown inpBillLast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown inpPayFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inpPayLast;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}