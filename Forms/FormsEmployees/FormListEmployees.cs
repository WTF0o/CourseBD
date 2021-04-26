using CourseBD.Class;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsEmployees
{
    public partial class FormListEmployees : Form
    {
        private SoccerContext db;
        public FormListEmployees()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.Employees.Load();
            dataGridView.DataSource = getDataSource();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }

        }

        private BindingList<Employees> getDataSource()
        {
            return db.Employees.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listEmployees = db.Employees.ToList();
                var filterEmployees = listEmployees.FindAll(Employees => Employees.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(Employees).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterEmployees;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListEmployees_Load(object sender, EventArgs e)
        {

            this.employeesTableAdapter.Fill(this.dataSet.employees);

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementEmployees formElementEmployees = new FormElementEmployees();
            DialogResult result = formElementEmployees.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Employees Employees = new Employees();
                Employees.email = formElementEmployees.textBoxEmail.Text.ToString();
                Employees.fio = formElementEmployees.textBoxFIO.Text.ToString();
                Employees.position = formElementEmployees.textBoxPosition.Text.ToString();
                Employees.phone = formElementEmployees.textBoxPhone.Text.ToString();

                db.Employees.Add(Employees);
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
                FormElementEmployees formElementEmployees = new FormElementEmployees();
                int idEmployees = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Employees Employees = db.Employees.Find(idEmployees);


                formElementEmployees.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementEmployees.textBoxEmail.Text = currentRow.Cells["email"].Value.ToString();
                formElementEmployees.textBoxFIO.Text = currentRow.Cells["fio"].Value.ToString();
                formElementEmployees.textBoxPosition.Text = currentRow.Cells["position"].Value.ToString();
                formElementEmployees.textBoxPhone.Text = currentRow.Cells["phone"].Value.ToString();


                DialogResult result = formElementEmployees.ShowDialog(this);
                if (result == DialogResult.OK && Employees != null)
                {

                    Employees.email = formElementEmployees.textBoxEmail.Text.ToString();
                    Employees.fio = formElementEmployees.textBoxFIO.Text.ToString();
                    Employees.position = formElementEmployees.textBoxPosition.Text.ToString();
                    Employees.phone = formElementEmployees.textBoxPhone.Text.ToString();

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
                int idEmployees = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                Employees Employees = db.Employees.Find(idEmployees);
                db.Employees.Remove(Employees);
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
