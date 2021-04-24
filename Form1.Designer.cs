
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
            this.tabRegisters = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tabReferences.SuspendLayout();
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
            // 
            // buttonBills
            // 
            this.buttonBills.Location = new System.Drawing.Point(6, 242);
            this.buttonBills.Name = "buttonBills";
            this.buttonBills.Size = new System.Drawing.Size(318, 53);
            this.buttonBills.TabIndex = 4;
            this.buttonBills.Text = "Счета";
            this.buttonBills.UseVisualStyleBackColor = true;
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Location = new System.Drawing.Point(6, 183);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Size = new System.Drawing.Size(318, 53);
            this.buttonEmployees.TabIndex = 3;
            this.buttonEmployees.Text = "Работники";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonWarehouse
            // 
            this.buttonWarehouse.Location = new System.Drawing.Point(6, 124);
            this.buttonWarehouse.Name = "buttonWarehouse";
            this.buttonWarehouse.Size = new System.Drawing.Size(318, 53);
            this.buttonWarehouse.TabIndex = 2;
            this.buttonWarehouse.Text = "Склады и ПВЗ";
            this.buttonWarehouse.UseVisualStyleBackColor = true;
            // 
            // buttonPartners
            // 
            this.buttonPartners.Location = new System.Drawing.Point(6, 65);
            this.buttonPartners.Name = "buttonPartners";
            this.buttonPartners.Size = new System.Drawing.Size(318, 53);
            this.buttonPartners.TabIndex = 1;
            this.buttonPartners.Text = "Партнеры";
            this.buttonPartners.UseVisualStyleBackColor = true;
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
            this.tabDocuments.Location = new System.Drawing.Point(4, 25);
            this.tabDocuments.Name = "tabDocuments";
            this.tabDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabDocuments.Size = new System.Drawing.Size(330, 380);
            this.tabDocuments.TabIndex = 0;
            this.tabDocuments.Text = "Документы";
            this.tabDocuments.UseVisualStyleBackColor = true;
            // 
            // tabRegisters
            // 
            this.tabRegisters.Location = new System.Drawing.Point(4, 25);
            this.tabRegisters.Name = "tabRegisters";
            this.tabRegisters.Size = new System.Drawing.Size(330, 380);
            this.tabRegisters.TabIndex = 2;
            this.tabRegisters.Text = "Регистры";
            this.tabRegisters.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 390);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabReferences.ResumeLayout(false);
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
    }
}

