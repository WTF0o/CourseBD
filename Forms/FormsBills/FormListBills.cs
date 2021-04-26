using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsBills
{
    public partial class FormListBills : Form
    {
        private SoccerContext db;

        public FormListBills()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Bills.Load();
            dataGridView.DataSource = getDataSource();
    }

        private BindingList<Bills> getDataSource()
        {
            return db.Bills.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listBillss = db.Bills.ToList();
                var filterBills = listBillss.FindAll(Bills => Bills.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(Bills).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterBills;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListBillss_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementBills formElementBills = new FormElementBills();
            DialogResult result = formElementBills.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Bills Bills = new Bills();
                Bills.id_currency = Int32.Parse(formElementBills.textBoxCurrency.Text.ToString());
                Bills.number_bill = formElementBills.textBoxNumberBill.Text.ToString();

                db.Bills.Add(Bills);
                db.SaveChanges();
                checkFilter();
                dataGridView.Refresh();
            }
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentRow = dataGridView.CurrentRow;
            if (currentRow != null)
            {
                FormElementBills formElementBills = new FormElementBills();
                int idBills = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Bills Bills = db.Bills.Find(idBills);

                formElementBills.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementBills.textBoxCurrency.Text = db.Currencies.Find(currentRow.Cells["id_currency"].Value).name;
                formElementBills.textBoxNumberBill.Text = Bills.number_bill;


                DialogResult result = formElementBills.ShowDialog(this);
                if (result == DialogResult.OK && Bills != null)
                {

                    Bills.id_currency = Int32.Parse(formElementBills.textBoxCurrency.Text.ToString());
                    Bills.number_bill = formElementBills.textBoxNumberBill.Text.ToString();

                    db.SaveChanges();
                    checkFilter();
                    dataGridView.Refresh();

                }
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView.CurrentRow;
            if (currentRow != null)
            {
                int idBills = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Bills Bills = db.Bills.Find(idBills);
                db.Bills.Remove(Bills);
                db.SaveChanges();
                checkFilter();
                dataGridView.Refresh();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            checkFilter();

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem != null && comboBoxSearch.SelectedItem.ToString() == "")
            {
                textBoxSearch.Text = "";
                checkFilter();
            }

        }
    }
}

