
namespace CourseBD.Forms.FormsCustomerOrder
{
    partial class FormElementCustomerOrder
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSum = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.labelIdWarehouse = new System.Windows.Forms.Label();
            this.textBoxIdWarehouse = new System.Windows.Forms.TextBox();
            this.labelIdPartner = new System.Windows.Forms.Label();
            this.textBoxIdPartner = new System.Windows.Forms.TextBox();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(40, 14);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(119, 22);
            this.textBoxId.TabIndex = 0;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(4, 17);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 17);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID:";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(165, 17);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(42, 17);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "Дата";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(334, 346);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(153, 34);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить и выйти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(3, 145);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 17);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Адрес:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(61, 142);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(399, 22);
            this.textBoxAddress.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSum);
            this.panel1.Controls.Add(this.textBoxSum);
            this.panel1.Controls.Add(this.labelCurrency);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCurrency);
            this.panel1.Controls.Add(this.labelEmployee);
            this.panel1.Controls.Add(this.textBoxEmployee);
            this.panel1.Controls.Add(this.labelIdWarehouse);
            this.panel1.Controls.Add(this.textBoxIdWarehouse);
            this.panel1.Controls.Add(this.labelIdPartner);
            this.panel1.Controls.Add(this.textBoxIdPartner);
            this.panel1.Controls.Add(this.checkBoxDelivery);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.textBoxId);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelFIO);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 391);
            this.panel1.TabIndex = 18;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(3, 183);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(54, 17);
            this.labelSum.TabIndex = 30;
            this.labelSum.Text = "Сумма:";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(61, 180);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(127, 22);
            this.textBoxSum.TabIndex = 29;
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(203, 82);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(84, 17);
            this.labelCurrency.TabIndex = 28;
            this.labelCurrency.Text = "Ид валюты:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ид валюты:";
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(313, 77);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrency.TabIndex = 26;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(3, 82);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(104, 17);
            this.labelEmployee.TabIndex = 25;
            this.labelEmployee.Text = "Ид работника:";
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Location = new System.Drawing.Point(113, 79);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(82, 22);
            this.textBoxEmployee.TabIndex = 24;
            // 
            // labelIdWarehouse
            // 
            this.labelIdWarehouse.AutoSize = true;
            this.labelIdWarehouse.Location = new System.Drawing.Point(210, 45);
            this.labelIdWarehouse.Name = "labelIdWarehouse";
            this.labelIdWarehouse.Size = new System.Drawing.Size(80, 17);
            this.labelIdWarehouse.TabIndex = 23;
            this.labelIdWarehouse.Text = "Ид склада:";
            // 
            // textBoxIdWarehouse
            // 
            this.textBoxIdWarehouse.Location = new System.Drawing.Point(313, 42);
            this.textBoxIdWarehouse.Name = "textBoxIdWarehouse";
            this.textBoxIdWarehouse.Size = new System.Drawing.Size(100, 22);
            this.textBoxIdWarehouse.TabIndex = 22;
            // 
            // labelIdPartner
            // 
            this.labelIdPartner.AutoSize = true;
            this.labelIdPartner.Location = new System.Drawing.Point(3, 45);
            this.labelIdPartner.Name = "labelIdPartner";
            this.labelIdPartner.Size = new System.Drawing.Size(97, 17);
            this.labelIdPartner.TabIndex = 21;
            this.labelIdPartner.Text = "Ид партнера:";
            // 
            // textBoxIdPartner
            // 
            this.textBoxIdPartner.Location = new System.Drawing.Point(106, 42);
            this.textBoxIdPartner.Name = "textBoxIdPartner";
            this.textBoxIdPartner.Size = new System.Drawing.Size(82, 22);
            this.textBoxIdPartner.TabIndex = 20;
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Location = new System.Drawing.Point(6, 115);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(93, 21);
            this.checkBoxDelivery.TabIndex = 19;
            this.checkBoxDelivery.Text = "Доставка";
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
            this.checkBoxDelivery.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(213, 14);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Location = new System.Drawing.Point(497, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 391);
            this.panel2.TabIndex = 19;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(550, 391);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormElementCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormElementCustomerOrder";
            this.Text = "Работник";
            this.Load += new System.EventHandler(this.FormElementCustomerOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonSave;
        protected internal System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelAddress;
        protected internal System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.Label labelEmployee;
        protected internal System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Label labelIdWarehouse;
        protected internal System.Windows.Forms.TextBox textBoxIdWarehouse;
        private System.Windows.Forms.Label labelIdPartner;
        protected internal System.Windows.Forms.TextBox textBoxIdPartner;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.Label labelSum;
        protected internal System.Windows.Forms.TextBox textBoxSum;
        protected internal System.Windows.Forms.DateTimePicker dateTimePicker;
        protected internal System.Windows.Forms.CheckBox checkBoxDelivery;
        protected internal System.Windows.Forms.DataGridView dataGridView;
    }
}