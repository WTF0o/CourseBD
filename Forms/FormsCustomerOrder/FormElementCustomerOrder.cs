using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsCustomerOrder
{
    public partial class FormElementCustomerOrder : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        public FormElementCustomerOrder()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                string query = "Select * From dbo.customer_orders";
                adapter = new SqlDataAdapter(query, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dataGridView.DataSource = ds.Tables["customer_orders_table"];

            }
        }
        private void addParametr<T>(SqlCommand command, String name, T parameter)
        {
            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = name,
                Value = parameter
            };
            command.Parameters.Add(sqlParameter);
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                connection.Open();
                string query = "Select * From dbo.customer_orders";
                SqlCommand command = new SqlCommand("CreateCustomerOrder", connection);
                command.CommandType = CommandType.StoredProcedure;
                addParametr(command, "id_partner", Int32.Parse(textBoxIdPartner.Text));
                addParametr(command, "id_warehouse", Int32.Parse(textBoxIdWarehouse.Text));
                addParametr(command, "id_employee", Int32.Parse(textBoxEmployee.Text));
                addParametr(command, "id_currency", Int32.Parse(textBoxCurrency.Text));
                addParametr(command, "date", dateTimePicker.Value);
                addParametr(command, "delivery", checkBoxDelivery.Checked);
                addParametr(command, "address_delivery", textBoxAddress.Text.ToString());
                addParametr(command, "order_sum", Double.Parse(textBoxSum.Text.ToString()));
                var idCustomerOrder = command.ExecuteScalar();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    row.Cells["id_customer_order"].Value = idCustomerOrder;
                    
                }

                adapter.Update(ds);
            }
            //this.DialogResult = DialogResult.OK;
           // this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormElementCustomerOrder_Load(object sender, EventArgs e)
        {


        }
    }
}
