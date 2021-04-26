
namespace CourseBD.Forms.FormsBills
{
    partial class FormElementBills
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNumberBill = new System.Windows.Forms.Label();
            this.textBoxNumberBill = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(43, 14);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(119, 22);
            this.textBoxId.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 17);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID:";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(181, 17);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(62, 17);
            this.labelCurrency.TabIndex = 3;
            this.labelCurrency.Text = "Валюта:";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(249, 14);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(214, 22);
            this.textBoxCurrency.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(310, 42);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 34);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить и выйти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNumberBill
            // 
            this.labelNumberBill.AutoSize = true;
            this.labelNumberBill.Location = new System.Drawing.Point(16, 52);
            this.labelNumberBill.Name = "labelNumberBill";
            this.labelNumberBill.Size = new System.Drawing.Size(97, 17);
            this.labelNumberBill.TabIndex = 10;
            this.labelNumberBill.Text = "Номер счета:";
            // 
            // textBoxNumberBill
            // 
            this.textBoxNumberBill.Location = new System.Drawing.Point(119, 49);
            this.textBoxNumberBill.Name = "textBoxNumberBill";
            this.textBoxNumberBill.Size = new System.Drawing.Size(185, 22);
            this.textBoxNumberBill.TabIndex = 9;
            // 
            // FormElementBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 83);
            this.Controls.Add(this.labelNumberBill);
            this.Controls.Add(this.textBoxNumberBill);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.textBoxCurrency);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Name = "FormElementBills";
            this.Text = "Счет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Button buttonSave;
        protected internal System.Windows.Forms.TextBox textBoxId;
        protected internal System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.Label labelNumberBill;
        protected internal System.Windows.Forms.TextBox textBoxNumberBill;
    }
}