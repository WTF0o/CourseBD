using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsCurrencies
{
    public partial class FormListCurrencies : Form
    {
        private SoccerContext db;
        public FormListCurrencies()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Currencies.Load();
            dataGridView.DataSource = getDataSource();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }

        }

        private BindingList<Currencies> getDataSource()
        {
            return db.Currencies.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listCurrenciess = db.Currencies.ToList();
                var filterCurrencies = listCurrenciess.FindAll(Currencies => Currencies.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(Currencies).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterCurrencies;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListCurrenciess_Load(object sender, EventArgs e)
        {

            this.currenciesTableAdapter.Fill(this.dataSet.currencies);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementCurrencies formElementCurrencies = new FormElementCurrencies();
            DialogResult result = formElementCurrencies.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Currencies Currencies = new Currencies();
                Currencies.name = formElementCurrencies.textBoxName.Text.ToString();

                db.Currencies.Add(Currencies);
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
                FormElementCurrencies formElementCurrencies = new FormElementCurrencies();
                int idCurrencies = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Currencies Currencies = db.Currencies.Find(idCurrencies);

                formElementCurrencies.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementCurrencies.textBoxName.Text = currentRow.Cells["name"].Value.ToString();


                DialogResult result = formElementCurrencies.ShowDialog(this);
                if (result == DialogResult.OK && Currencies != null)
                {

                    Currencies.name = formElementCurrencies.textBoxName.Text.ToString();

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
                int idCurrencies = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Currencies Currencies = db.Currencies.Find(idCurrencies);
                db.Currencies.Remove(Currencies);
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
