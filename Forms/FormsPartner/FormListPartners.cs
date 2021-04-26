using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsPartner
{
    public partial class FormListPartners : Form
    {
        private SoccerContext db;
        public FormListPartners()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Partner.Load();
            dataGridView.DataSource = getDataSource();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }

        }

        private BindingList<Partner> getDataSource()
        {
            return db.Partner.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listPartners = db.Partner.ToList();
                var filterPartner = listPartners.FindAll(Partner => Partner.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(Partner).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterPartner;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListPartners_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.warehouse". При необходимости она может быть перемещена или удалена.

            this.partnerTableAdapter.Fill(this.dataSet.partner);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementPartner formElementPartner = new FormElementPartner();
            DialogResult result = formElementPartner.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Partner Partner = new Partner();
                Partner.supplier = formElementPartner.checkBoxSupplier.Checked;
                Partner.email = formElementPartner.textBoxEmail.Text.ToString();
                Partner.fio = formElementPartner.textBoxFIO.Text.ToString();
                Partner.address = formElementPartner.textBoxAddress.Text.ToString();
                Partner.phone = formElementPartner.textBoxPhone.Text.ToString();
                Partner.country = formElementPartner.textBoxCountry.Text.ToString();

                db.Partner.Add(Partner);
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
                FormElementPartner formElementPartner = new FormElementPartner();
                int idPartner = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Partner Partner = db.Partner.Find(idPartner);


                formElementPartner.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementPartner.checkBoxSupplier.Checked = (bool)currentRow.Cells["Supplier"].Value;
                formElementPartner.textBoxEmail.Text = currentRow.Cells["email"].Value.ToString();
                formElementPartner.textBoxFIO.Text = currentRow.Cells["fio"].Value.ToString();
                formElementPartner.textBoxAddress.Text = currentRow.Cells["address"].Value.ToString();
                formElementPartner.textBoxPhone.Text = currentRow.Cells["phone"].Value.ToString();
                formElementPartner.textBoxCountry.Text = currentRow.Cells["country"].Value.ToString();


                DialogResult result = formElementPartner.ShowDialog(this);
                if (result == DialogResult.OK && Partner != null)
                {

                    Partner.supplier = formElementPartner.checkBoxSupplier.Checked;
                    Partner.email = formElementPartner.textBoxEmail.Text.ToString();
                    Partner.fio = formElementPartner.textBoxFIO.Text.ToString();
                    Partner.address = formElementPartner.textBoxAddress.Text.ToString();
                    Partner.phone = formElementPartner.textBoxPhone.Text.ToString();
                    Partner.country = formElementPartner.textBoxCountry.Text.ToString();

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
                int idPartner = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Partner Partner = db.Partner.Find(idPartner);
                db.Partner.Remove(Partner);
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
