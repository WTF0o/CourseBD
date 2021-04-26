using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsWarehouse
{
    public partial class FormListWarehouse : Form
    {
        private SoccerContext db;
        public FormListWarehouse()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Warehouse.Load();
            dataGridView.DataSource = getDataSource();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }

        }

        private BindingList<Warehouse> getDataSource()
        {
            return db.Warehouse.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listWarehouses = db.Warehouse.ToList();
                var filterWarehouse = listWarehouses.FindAll(Warehouse => Warehouse.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(Warehouse).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterWarehouse;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListWarehouses_Load(object sender, EventArgs e)
        {

            this.warehouseTableAdapter.Fill(this.dataSet.warehouse);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementWarehouse formElementWarehouse = new FormElementWarehouse();
            DialogResult result = formElementWarehouse.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Warehouse Warehouse = new Warehouse();
                Warehouse.name = formElementWarehouse.textBoxName.Text.ToString();
                Warehouse.address = formElementWarehouse.textBoxAddress.Text.ToString();

                db.Warehouse.Add(Warehouse);
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
                FormElementWarehouse formElementWarehouse = new FormElementWarehouse();
                int idWarehouse = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Warehouse Warehouse = db.Warehouse.Find(idWarehouse);

                formElementWarehouse.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementWarehouse.textBoxName.Text = currentRow.Cells["name"].Value.ToString();
                formElementWarehouse.textBoxAddress.Text = currentRow.Cells["address"].Value.ToString();


                DialogResult result = formElementWarehouse.ShowDialog(this);
                if (result == DialogResult.OK && Warehouse != null)
                {

                    Warehouse.name = formElementWarehouse.textBoxName.Text.ToString();
                    Warehouse.address = formElementWarehouse.textBoxAddress.Text.ToString();

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
                int idWarehouse = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Warehouse Warehouse = db.Warehouse.Find(idWarehouse);
                db.Warehouse.Remove(Warehouse);
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
