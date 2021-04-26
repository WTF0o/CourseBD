using CourseBD.Forms.FormsEmployees;
using CourseBD.Forms.FormsPartner;
using CourseBD.Forms.FormsWarehouse;
using CourseBD.Forms.FormsCurrencies;
using CourseBD.Forms.FormsBills;
using CourseBD.Forms.FormsCustomerOrder;
using System;
using System.Windows.Forms;

namespace CourseBD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNomenclatures_Click(object sender, EventArgs e)
        {
            FormListNomenclature nomenclauteForm = new FormListNomenclature();
            nomenclauteForm.Show();
        }

        private void buttonPartners_Click(object sender, EventArgs e)
        {
            FormListPartners listPartners = new FormListPartners();
            listPartners.Show();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            FormListWarehouse listWarehouse = new FormListWarehouse();
            listWarehouse.Show();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            FormListEmployees listEmloyees = new FormListEmployees();
            listEmloyees.Show();
        }

        private void buttonCurrencies_Click(object sender, EventArgs e)
        {
            FormListCurrencies listCurrencies  = new FormListCurrencies();
            listCurrencies.Show();
        }

        private void buttonBills_Click(object sender, EventArgs e)
        {
            FormListBills listBills = new FormListBills();
            listBills.Show();
        }

        private void buttonCustomerOrder_Click(object sender, EventArgs e)
        {
            FormListCustomerOrder listCustomerOrder = new FormListCustomerOrder();
            listCustomerOrder.Show();
        }
    }
}
