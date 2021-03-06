﻿namespace BillingTestForm
{
    partial class BillingEditor
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
            this.rbBefore = new System.Windows.Forms.RadioButton();
            this.rbAfterFixed = new System.Windows.Forms.RadioButton();
            this.rbAfterInterval = new System.Windows.Forms.RadioButton();
            this.gbAfterFixed = new System.Windows.Forms.GroupBox();
            this.checkOnlyWorkDays = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numFixedDays = new System.Windows.Forms.NumericUpDown();
            this.gbAfterInterval = new System.Windows.Forms.GroupBox();
            this.btnRemoveInterval = new System.Windows.Forms.Button();
            this.btnEditInterval = new System.Windows.Forms.Button();
            this.btnAddInterval = new System.Windows.Forms.Button();
            this.listInterval = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTesting = new System.Windows.Forms.GroupBox();
            this.gbAfterFixed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedDays)).BeginInit();
            this.gbAfterInterval.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTesting.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbBefore
            // 
            this.rbBefore.AutoSize = true;
            this.rbBefore.Location = new System.Drawing.Point(12, 11);
            this.rbBefore.Name = "rbBefore";
            this.rbBefore.Size = new System.Drawing.Size(86, 17);
            this.rbBefore.TabIndex = 0;
            this.rbBefore.TabStop = true;
            this.rbBefore.Text = "Предоплата";
            this.rbBefore.UseVisualStyleBackColor = true;
            this.rbBefore.CheckedChanged += new System.EventHandler(this.UpdateForm);
            // 
            // rbAfterFixed
            // 
            this.rbAfterFixed.AutoSize = true;
            this.rbAfterFixed.Location = new System.Drawing.Point(12, 34);
            this.rbAfterFixed.Name = "rbAfterFixed";
            this.rbAfterFixed.Size = new System.Drawing.Size(168, 17);
            this.rbAfterFixed.TabIndex = 1;
            this.rbAfterFixed.TabStop = true;
            this.rbAfterFixed.Text = "Постоплата фиксированная";
            this.rbAfterFixed.UseVisualStyleBackColor = true;
            this.rbAfterFixed.CheckedChanged += new System.EventHandler(this.UpdateForm);
            // 
            // rbAfterInterval
            // 
            this.rbAfterInterval.AutoSize = true;
            this.rbAfterInterval.Location = new System.Drawing.Point(12, 57);
            this.rbAfterInterval.Name = "rbAfterInterval";
            this.rbAfterInterval.Size = new System.Drawing.Size(159, 17);
            this.rbAfterInterval.TabIndex = 2;
            this.rbAfterInterval.TabStop = true;
            this.rbAfterInterval.Text = "Постоплата интервальная";
            this.rbAfterInterval.UseVisualStyleBackColor = true;
            this.rbAfterInterval.CheckedChanged += new System.EventHandler(this.UpdateForm);
            // 
            // gbAfterFixed
            // 
            this.gbAfterFixed.Controls.Add(this.checkOnlyWorkDays);
            this.gbAfterFixed.Controls.Add(this.label1);
            this.gbAfterFixed.Controls.Add(this.numFixedDays);
            this.gbAfterFixed.Location = new System.Drawing.Point(12, 102);
            this.gbAfterFixed.Name = "gbAfterFixed";
            this.gbAfterFixed.Size = new System.Drawing.Size(231, 72);
            this.gbAfterFixed.TabIndex = 1;
            this.gbAfterFixed.TabStop = false;
            this.gbAfterFixed.Text = "Фиксированная";
            // 
            // checkOnlyWorkDays
            // 
            this.checkOnlyWorkDays.AutoSize = true;
            this.checkOnlyWorkDays.Location = new System.Drawing.Point(16, 19);
            this.checkOnlyWorkDays.Name = "checkOnlyWorkDays";
            this.checkOnlyWorkDays.Size = new System.Drawing.Size(128, 17);
            this.checkOnlyWorkDays.TabIndex = 0;
            this.checkOnlyWorkDays.Text = "Только рабочие дни";
            this.checkOnlyWorkDays.UseVisualStyleBackColor = true;
            this.checkOnlyWorkDays.CheckedChanged += new System.EventHandler(this.UpdateForm);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число дней для оплаты:";
            // 
            // numFixedDays
            // 
            this.numFixedDays.Location = new System.Drawing.Point(149, 37);
            this.numFixedDays.Name = "numFixedDays";
            this.numFixedDays.Size = new System.Drawing.Size(58, 20);
            this.numFixedDays.TabIndex = 1;
            this.numFixedDays.ValueChanged += new System.EventHandler(this.UpdateForm);
            // 
            // gbAfterInterval
            // 
            this.gbAfterInterval.Controls.Add(this.btnRemoveInterval);
            this.gbAfterInterval.Controls.Add(this.btnEditInterval);
            this.gbAfterInterval.Controls.Add(this.btnAddInterval);
            this.gbAfterInterval.Controls.Add(this.listInterval);
            this.gbAfterInterval.Location = new System.Drawing.Point(12, 102);
            this.gbAfterInterval.Name = "gbAfterInterval";
            this.gbAfterInterval.Size = new System.Drawing.Size(288, 165);
            this.gbAfterInterval.TabIndex = 2;
            this.gbAfterInterval.TabStop = false;
            this.gbAfterInterval.Text = "Интервальная";
            // 
            // btnRemoveInterval
            // 
            this.btnRemoveInterval.Location = new System.Drawing.Point(198, 133);
            this.btnRemoveInterval.Name = "btnRemoveInterval";
            this.btnRemoveInterval.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveInterval.TabIndex = 1;
            this.btnRemoveInterval.Text = "Удалить";
            this.btnRemoveInterval.UseVisualStyleBackColor = true;
            this.btnRemoveInterval.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditInterval
            // 
            this.btnEditInterval.Location = new System.Drawing.Point(107, 133);
            this.btnEditInterval.Name = "btnEditInterval";
            this.btnEditInterval.Size = new System.Drawing.Size(75, 23);
            this.btnEditInterval.TabIndex = 1;
            this.btnEditInterval.Text = "Изменить";
            this.btnEditInterval.UseVisualStyleBackColor = true;
            this.btnEditInterval.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddInterval
            // 
            this.btnAddInterval.Location = new System.Drawing.Point(17, 133);
            this.btnAddInterval.Name = "btnAddInterval";
            this.btnAddInterval.Size = new System.Drawing.Size(75, 23);
            this.btnAddInterval.TabIndex = 1;
            this.btnAddInterval.Text = "Добавить";
            this.btnAddInterval.UseVisualStyleBackColor = true;
            this.btnAddInterval.Click += new System.EventHandler(this.btnAddInterval_Click);
            // 
            // listInterval
            // 
            this.listInterval.FormattingEnabled = true;
            this.listInterval.Location = new System.Drawing.Point(17, 19);
            this.listInterval.Name = "listInterval";
            this.listInterval.Size = new System.Drawing.Size(256, 108);
            this.listInterval.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.rbBefore);
            this.panel1.Controls.Add(this.rbAfterFixed);
            this.panel1.Controls.Add(this.rbAfterInterval);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(397, 282);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Сохранить";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(500, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(86, 19);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(137, 20);
            this.dtp.TabIndex = 6;
            this.dtp.ValueChanged += new System.EventHandler(this.UpdateForm);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(13, 50);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(35, 13);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата счета:";
            // 
            // gbTesting
            // 
            this.gbTesting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTesting.Controls.Add(this.dtp);
            this.gbTesting.Controls.Add(this.label3);
            this.gbTesting.Controls.Add(this.ResultLabel);
            this.gbTesting.Location = new System.Drawing.Point(315, 12);
            this.gbTesting.Name = "gbTesting";
            this.gbTesting.Size = new System.Drawing.Size(260, 255);
            this.gbTesting.TabIndex = 3;
            this.gbTesting.TabStop = false;
            this.gbTesting.Text = "Тестирование:";
            this.gbTesting.Visible = false;
            // 
            // BillingEditor
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 318);
            this.Controls.Add(this.gbTesting);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbAfterInterval);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbAfterFixed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BillingEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор оплаты";
            this.Load += new System.EventHandler(this.BillingEditor_Load);
            this.gbAfterFixed.ResumeLayout(false);
            this.gbAfterFixed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFixedDays)).EndInit();
            this.gbAfterInterval.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbTesting.ResumeLayout(false);
            this.gbTesting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbBefore;
        private System.Windows.Forms.RadioButton rbAfterFixed;
        private System.Windows.Forms.RadioButton rbAfterInterval;
        private System.Windows.Forms.GroupBox gbAfterFixed;
        private System.Windows.Forms.CheckBox checkOnlyWorkDays;
        private System.Windows.Forms.GroupBox gbAfterInterval;
        private System.Windows.Forms.Button btnRemoveInterval;
        private System.Windows.Forms.Button btnEditInterval;
        private System.Windows.Forms.Button btnAddInterval;
        private System.Windows.Forms.ListBox listInterval;
        private System.Windows.Forms.NumericUpDown numFixedDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTesting;
    }
}