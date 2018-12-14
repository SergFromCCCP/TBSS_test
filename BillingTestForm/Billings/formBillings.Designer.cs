namespace BillingTestForm
{
    partial class formBillings
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GO = new System.Windows.Forms.Button();
            this.constructor = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(302, 293);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 23);
            this.GO.TabIndex = 0;
            this.GO.Text = "button1";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // constructor
            // 
            this.constructor.Location = new System.Drawing.Point(132, 12);
            this.constructor.Name = "constructor";
            this.constructor.Size = new System.Drawing.Size(391, 20);
            this.constructor.TabIndex = 1;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(453, 233);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 2;
            this.result.Text = "label1";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(372, 121);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(159, 20);
            this.dtp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Конструктор оплаты:";
            // 
            // formBillings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.constructor);
            this.Controls.Add(this.GO);
            this.Name = "formBillings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.TextBox constructor;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label1;
    }
}

