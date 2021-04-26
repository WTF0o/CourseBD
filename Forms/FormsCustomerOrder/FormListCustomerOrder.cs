using CourseBD.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsCustomerOrder
{
    public partial class FormListCustomerOrder : Form
    {
        private SoccerContext db;
        public FormListCustomerOrder()
        {
            InitializeComponent();
/*            db = new SoccerContext();
            db.CustomerOrder.Load();
            //dataGridView.DataSource = getDataSource();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                comboBoxSearch.Items.Add(column.Name);
            }*/

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                string query = "Select * From dbo.customer_orders";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView.DataSource = ds.Tables["customer_orders"];

            }

        }

        private BindingList<CustomerOrder> getDataSource()
        {
            return db.CustomerOrder.Local.ToBindingList();
        }

        private void checkFilter()
        {
            if (comboBoxSearch.SelectedItem != null &&
                comboBoxSearch.SelectedItem.ToString() != "" &&
                textBoxSearch.Text.ToString() != "")
            {
                var listCustomerOrder = db.CustomerOrder.ToList();
                var filterCustomerOrder = listCustomerOrder.FindAll(CustomerOrder => CustomerOrder.GetType().GetProperty(comboBoxSearch.SelectedItem.ToString()).GetValue(CustomerOrder).ToString() == textBoxSearch.Text.ToString());
                dataGridView.DataSource = filterCustomerOrder;
            }
            else dataGridView.DataSource = getDataSource();
        }


        private void FormListCustomerOrder_Load(object sender, EventArgs e)
        {

            //this.customer_ordersTableAdapter.Fill(this.dataSet.customer_orders);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormElementCustomerOrder formElementCustomerOrder = new FormElementCustomerOrder();
            DialogResult result = formElementCustomerOrder.ShowDialog(this);
/*
            if (result == DialogResult.OK)
            {
                CustomerOrder CustomerOrder = new CustomerOrder();
                double sum = 0;
                CustomerOrder.id_partner = Int32.Parse(formElementCustomerOrder.textBoxIdPartner.Text.ToString());
                CustomerOrder.id_warehouse = Int32.Parse(formElementCustomerOrder.textBoxIdWarehouse.Text.ToString());
                CustomerOrder.id_employee = Int32.Parse(formElementCustomerOrder.textBoxEmployee.TextToString());
                CustomerOrder.id_currency = Int32.Parse(formElementCustomerOrder.textBoxCurrency.Text.ToString());
                CustomerOrder.date = formElementCustomerOrder.dateTimePicker.Value;
                CustomerOrder.delivery = formElementCustomerOrder.checkBoxDelivery.Checked;
                CustomerOrder.address_delivery = formElementCustomerOrder.textBoxAddress.Text.ToString();
                //CustomerOrder.order_sum = Double.Parse(formElementCustomerOrder.textBoxSum.ToString(), CultureInfo.InvariantCulture);
                db.CustomerOrder.Add(CustomerOrder);
                db.SaveChanges();
                
                foreach (DataGridViewRow row in formElementCustomerOrder.dataGridView.Rows)
                {
                    CustomerOrderTable customerOrderTable = new CustomerOrderTable();
                    customerOrderTable.id_customer_order = CustomerOrder.id;
                    customerOrderTable.id_nomenclature = Int32.Parse(row.Cells["idnomenclature"].Value.ToString());
                    customerOrderTable.count = Double.Parse(row.Cells["count"].Value.ToString(), CultureInfo.InvariantCulture);
                    customerOrderTable.cost = Double.Parse(row.Cells["cost"].Value.ToString(), CultureInfo.InvariantCulture);
                    customerOrderTable.sum = customerOrderTable.cost * customerOrderTable.count;
                    db.CustomerOrderTable.Add(customerOrderTable);
                    sum += customerOrderTable.sum;
                }

                CustomerOrder.order_sum = sum;
                db.SaveChanges();

                checkFilter();
                dataGridView.Refresh();
            }*/
        }

        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           /* var currentRow = dataGridView.CurrentRow;
            if (currentRow != null)
            {
                FormElementCustomerOrder formElementCustomerOrder = new FormElementCustomerOrder();
                int idCustomerOrder = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                CustomerOrder CustomerOrder = db.CustomerOrder.Find(idCustomerOrder);


                formElementCustomerOrder.textBoxId.Text = currentRow.Cells["id"].Value.ToString();
                formElementCustomerOrder.textBoxAddress.Text = currentRow.Cells["email"].Value.ToString();
                formElementCustomerOrder.textBoxFIO.Text = currentRow.Cells["fio"].Value.ToString();
                formElementCustomerOrder.textBoxPosition.Text = currentRow.Cells["position"].Value.ToString();
                formElementCustomerOrder.textBoxPhone.Text = currentRow.Cells["phone"].Value.ToString();


                DialogResult result = formElementCustomerOrder.ShowDialog(this);
                if (result == DialogResult.OK && CustomerOrder != null)
                {

                    CustomerOrder.email = formElementCustomerOrder.textBoxEmail.Text.ToString();
                    CustomerOrder.fio = formElementCustomerOrder.textBoxFIO.Text.ToString();
                    CustomerOrder.position = formElementCustomerOrder.textBoxPosition.Text.ToString();
                    CustomerOrder.phone = formElementCustomerOrder.textBoxPhone.Text.ToString();

                    db.SaveChanges();
                    checkFilter();
                    dataGridView.Refresh();

                }
            }*/

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var currentRow = dataGridView.CurrentRow;
            if (currentRow != null)
            {
                int idCustomerOrder = Int32.Parse(currentRow.Cells["id"].Value.ToString());
                CustomerOrder CustomerOrder = db.CustomerOrder.Find(idCustomerOrder);
                db.CustomerOrder.Remove(CustomerOrder);
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
