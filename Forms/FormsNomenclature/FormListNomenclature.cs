using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;


namespace CourseBD
{
    public partial class FormListNomenclature : Form
    {
        private SoccerContext db;
        public FormListNomenclature()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Nomenclature.Load();
            dataGridView.DataSource = getDataSource();
         
           foreach(DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }

        }

        private BindingList<Nomenclature> getDataSource()
        {
            return db.Nomenclature.Local.ToBindingList();
        }

        private void checkFilterNomenclature()
        {
            if (comboBoxSearch.SelectedItem != null && 
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != ""){
                var listNomenclatures = db.Nomenclature.ToList();
                var filterNomenclature = listNomenclatures.FindAll(nomenclature => nomenclature.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(nomenclature).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterNomenclature;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListNomenclatures_Load(object sender, EventArgs e)
        {

            this.nomenclatureTableAdapter.Fill(this.dataSet.nomenclature);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementNomenclature formElementNomenclature = new FormElementNomenclature();
            DialogResult result = formElementNomenclature.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Nomenclature nomenclature = new Nomenclature();
                nomenclature.name = formElementNomenclature.textBoxName.Text.ToString();
                nomenclature.manufacturer = formElementNomenclature.textBoxManufacturer.Text.ToString();
                nomenclature.country = formElementNomenclature.textBoxCountry.Text.ToString();

                db.Nomenclature.Add(nomenclature);
                db.SaveChanges();
                checkFilterNomenclature();
                dataGridView.Refresh();
            }
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var currentRow = dataGridView.CurrentRow;
            if(currentRow != null)
            {
                FormElementNomenclature formElementNomenclature = new FormElementNomenclature();
                int idNomenclature = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Nomenclature nomenclature = db.Nomenclature.Find(idNomenclature);

                formElementNomenclature.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementNomenclature.textBoxName.Text = currentRow.Cells["name"].Value.ToString();
                formElementNomenclature.textBoxManufacturer.Text = currentRow.Cells["manufacturer"].Value.ToString();
                formElementNomenclature.textBoxCountry.Text = currentRow.Cells["country"].Value.ToString();


                DialogResult result = formElementNomenclature.ShowDialog(this);
                if (result == DialogResult.OK && nomenclature != null)
                {

                    nomenclature.name = formElementNomenclature.textBoxName.Text.ToString();
                    nomenclature.manufacturer = formElementNomenclature.textBoxManufacturer.Text.ToString();
                    nomenclature.country = formElementNomenclature.textBoxCountry.Text.ToString();
                    db.SaveChanges();
                    checkFilterNomenclature();
                    dataGridView.Refresh();

                }
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView.CurrentRow;
            if(currentRow != null)
            {
                int idNomenclature = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Nomenclature nomenclature = db.Nomenclature.Find(idNomenclature);
                db.Nomenclature.Remove(nomenclature);
                db.SaveChanges();
                checkFilterNomenclature();
                dataGridView.Refresh();
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            checkFilterNomenclature();

        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem != null && comboBoxSearch.SelectedItem.ToString() == "")
            {
                textBoxSearch.Text = "";
                checkFilterNomenclature();
            }        

        }
    }
}
