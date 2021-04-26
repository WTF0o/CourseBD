
namespace CourseBD
{
    partial class MainForm
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabReferences = new System.Windows.Forms.TabPage();
            this.buttonCurrencies = new System.Windows.Forms.Button();
            this.buttonBills = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonWarehouse = new System.Windows.Forms.Button();
            this.buttonPartners = new System.Windows.Forms.Button();
            this.buttonNomenclatures = new System.Windows.Forms.Button();
            this.tabDocuments = new System.Windows.Forms.TabPage();
            this.buttonExpenseCashOrder = new System.Windows.Forms.Button();
            this.buttonCashReceiptOrder = new System.Windows.Forms.Button();
            this.buttonRefundSuppler = new System.Windows.Forms.Button();
            this.buttonRefundCustomer = new System.Windows.Forms.Button();
            this.buttonSupplerOrder = new System.Windows.Forms.Button();
            this.buttonCustomerOrder = new System.Windows.Forms.Button();
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.buttonCashInBills = new System.Windows.Forms.Button();
            this.buttonNomenclatureInWarehouse = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabReferences.SuspendLayout();
            this.tabDocuments.SuspendLayout();
            this.tabRegisters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabReferences);
            this.tabs.Controls.Add(this.tabDocuments);
            this.tabs.Controls.Add(this.tabRegisters);
            this.tabs.Location = new System.Drawing.Point(-4, 1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(338, 409);
            this.tabs.TabIndex = 0;
            // 
            // tabReferences
            // 
            this.tabReferences.Controls.Add(this.buttonCurrencies);
            this.tabReferences.Controls.Add(this.buttonBills);
            this.tabReferences.Controls.Add(this.buttonEmployees);
            this.tabReferences.Controls.Add(this.buttonWarehouse);
            this.tabReferences.Controls.Add(this.buttonPartners);
            this.tabReferences.Controls.Add(this.buttonNomenclatures);
            this.tabReferences.Location = new System.Drawing.Point(4, 25);
            this.tabReferences.Name = "tabReferences";
            this.tabReferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabReferences.Size = new System.Drawing.Size(330, 380);
            this.tabReferences.TabIndex = 1;
            this.tabReferences.Text = "Справочники";
            this.tabReferences.UseVisualStyleBackColor = true;
            // 
            // buttonCurrencies
            // 
            this.buttonCurrencies.Location = new System.Drawing.Point(6, 301);
            this.buttonCurrencies.Name = "buttonCurrencies";
            this.buttonCurrencies.Size = new System.Drawing.Size(318, 53);
            this.buttonCurrencies.TabIndex = 5;
            this.buttonCurrencies.Text = "Валюта";
            this.buttonCurrencies.UseVisualStyleBackColor = true;
            this.buttonCurrencies.Click += new System.EventHandler(this.buttonCurrencies_Click);
            // 
            // buttonBills
            // 
            this.buttonBills.Location = new System.Drawing.Point(6, 242);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(318, 53);
            this.buttonBills.TabIndex = 4;
            this.buttonBills.Text = "Счета";
            this.buttonBills.UseVisualStyleBackColor = true;
            this.buttonBills.Click += new System.EventHandler(this.buttonBills_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(6, 183);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(318, 53);
            this.buttonEmployees.TabIndex = 3;
            this.buttonEmployees.Text = "Работники";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Location = new System.Drawing.Point(6, 124);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(318, 53);
            this.buttonWarehouse.TabIndex = 2;
            this.buttonWarehouse.Text = "Склады и ПВЗ";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            this.buttonWarehouse.Click += new System.EventHandler(this.buttonWarehouse_Click);
            // 
            // buttonPartners
            // 
            this.buttonPartners.Location = new System.Drawing.Point(6, 65);
            this.buttonPartners.Name = "buttonPartners";
            this.buttonPartners.Size = new System.Drawing.Size(318, 53);
            this.buttonPartners.TabIndex = 1;
            this.buttonPartners.Text = "Партнеры";
            this.buttonPartners.UseVisualStyleBackColor = true;
            this.buttonPartners.Click += new System.EventHandler(this.buttonPartners_Click);
            // 
            // buttonNomenclatures
            // 
            this.buttonNomenclatures.Location = new System.Drawing.Point(6, 6);
            this.buttonNomenclatures.Name = "buttonNomenclatures";
            this.buttonNomenclatures.Size = new System.Drawing.Size(318, 53);
            this.buttonNomenclatures.TabIndex = 0;
            this.buttonNomenclatures.Text = "Номенклатура";
            this.buttonNomenclatures.UseVisualStyleBackColor = true;
            this.buttonNomenclatures.Click += new System.EventHandler(this.buttonNomenclatures_Click);
            // 
            // tabDocuments
            // 
            this.tabDocuments.Controls.Add(this.buttonExpenseCashOrder);
            this.tabDocuments.Controls.Add(this.buttonCashReceiptOrder);
            this.tabDocuments.Controls.Add(this.buttonRefundSuppler);
            this.tabDocuments.Controls.Add(this.buttonRefundCustomer);
            this.tabDocuments.Controls.Add(this.buttonSupplerOrder);
            this.tabDocuments.Controls.Add(this.buttonCustomerOrder);
            this.tabDocuments.Location = new System.Drawing.Point(4, 25);
            this.tabDocuments.Name = "tabDocuments";
            this.tabDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocuments.Size = new System.Drawing.Size(330, 380);
            this.tabDocuments.TabIndex = 0;
            this.tabDocuments.Text = "Документы";
            this.tabDocuments.UseVisualStyleBackColor = true;
            // 
            // buttonExpenseCashOrder
            // 
            this.buttonExpenseCashOrder.Location = new System.Drawing.Point(6, 311);
            this.buttonExpenseCashOrder.Name = "buttonExpenseCashOrder";
            this.buttonExpenseCashOrder.Size = new System.Drawing.Size(318, 55);
            this.buttonExpenseCashOrder.TabIndex = 6;
            this.buttonExpenseCashOrder.Text = "Расходный кассовый ордер";
            this.buttonExpenseCashOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCashReceiptOrder
            // 
            this.buttonCashReceiptOrder.Location = new System.Drawing.Point(6, 250);
            this.buttonCashReceiptOrder.Name = "buttonCashReceiptOrder";
            this.buttonCashReceiptOrder.Size = new System.Drawing.Size(318, 55);
            this.buttonCashReceiptOrder.TabIndex = 5;
            this.buttonCashReceiptOrder.Text = "Приходный кассовый ордер";
            this.buttonCashReceiptOrder.UseVisualStyleBackColor = true;
            // 
            // buttonRefundSuppler
            // 
            this.buttonRefundSuppler.Location = new System.Drawing.Point(6, 189);
            this.buttonRefundSuppler.Name = "buttonRefundSuppler";
            this.buttonRefundSuppler.Size = new System.Drawing.Size(318, 55);
            this.buttonRefundSuppler.TabIndex = 4;
            this.buttonRefundSuppler.Text = "Возврат поставщику";
            this.buttonRefundSuppler.UseVisualStyleBackColor = true;
            // 
            // buttonRefundCustomer
            // 
            this.buttonRefundCustomer.Location = new System.Drawing.Point(6, 128);
            this.buttonRefundCustomer.Name = "buttonRefundCustomer";
            this.buttonRefundCustomer.Size = new System.Drawing.Size(318, 55);
            this.buttonRefundCustomer.TabIndex = 3;
            this.buttonRefundCustomer.Text = "Возврат от клиента";
            this.buttonRefundCustomer.UseVisualStyleBackColor = true;
            // 
            // buttonSupplerOrder
            // 
            this.buttonSupplerOrder.Location = new System.Drawing.Point(6, 67);
            this.buttonSupplerOrder.Name = "buttonSupplerOrder";
            this.buttonSupplerOrder.Size = new System.Drawing.Size(318, 55);
            this.buttonSupplerOrder.TabIndex = 2;
            this.buttonSupplerOrder.Text = "Заказ поставщику";
            this.buttonSupplerOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCustomerOrder
            // 
            this.buttonCustomerOrder.Location = new System.Drawing.Point(6, 6);
            this.buttonCustomerOrder.Name = "buttonCustomerOrder";
            this.buttonCustomerOrder.Size = new System.Drawing.Size(318, 55);
            this.buttonCustomerOrder.TabIndex = 1;
            this.buttonCustomerOrder.Text = "Заказ клиента";
            this.buttonCustomerOrder.UseVisualStyleBackColor = true;
            this.buttonCustomerOrder.Click += new System.EventHandler(this.buttonCustomerOrder_Click);
            // 
            // tabRegisters
            // 
            this.tabRegisters.Controls.Add(this.buttonCashInBills);
            this.tabRegisters.Controls.Add(this.buttonNomenclatureInWarehouse);
            this.tabRegisters.Location = new System.Drawing.Point(4, 25);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Size = new System.Drawing.Size(330, 380);
            this.tabRegisters.TabIndex = 2;
            this.tabRegisters.Text = "Регистры";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // buttonCashInBills
            // 
            this.buttonCashInBills.Location = new System.Drawing.Point(12, 194);
            this.buttonCashInBills.Name = "buttonCashInBills";
            this.buttonCashInBills.Size = new System.Drawing.Size(303, 158);
            this.buttonCashInBills.TabIndex = 6;
            this.buttonCashInBills.Text = "Деньги на счетах";
            this.buttonCashInBills.UseVisualStyleBackColor = true;
            // 
            // buttonNomenclatureInWarehouse
            // 
            this.buttonNomenclatureInWarehouse.Location = new System.Drawing.Point(12, 13);
            this.buttonNomenclatureInWarehouse.Name = "buttonNomenclatureInWarehouse";
            this.buttonNomenclatureInWarehouse.Size = new System.Drawing.Size(303, 158);
            this.buttonNomenclatureInWarehouse.TabIndex = 5;
            this.buttonNomenclatureInWarehouse.Text = "Номенклатура на складах";
            this.buttonNomenclatureInWarehouse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 395);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabReferences.ResumeLayout(false);
            this.tabDocuments.ResumeLayout(false);
            this.tabRegisters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabDocuments;
        private System.Windows.Forms.TabPage tabReferences;
        private System.Windows.Forms.TabPage tabRegisters;
        private System.Windows.Forms.Button buttonNomenclatures;
        private System.Windows.Forms.Button buttonCurrencies;
        private System.Windows.Forms.Button buttonBills;
        private System.Windows.Forms.Button buttonEmployees;
        private System.Windows.Forms.Button buttonWarehouse;
        private System.Windows.Forms.Button buttonPartners;
        private System.Windows.Forms.Button buttonRefundSuppler;
        private System.Windows.Forms.Button buttonRefundCustomer;
        private System.Windows.Forms.Button buttonSupplerOrder;
        private System.Windows.Forms.Button buttonCustomerOrder;
        private System.Windows.Forms.Button buttonCashInBills;
        private System.Windows.Forms.Button buttonNomenclatureInWarehouse;
        private System.Windows.Forms.Button buttonExpenseCashOrder;
        private System.Windows.Forms.Button buttonCashReceiptOrder;
    }
}

