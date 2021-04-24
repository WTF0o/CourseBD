using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBD
{
    public partial class FormListNomenclature : Form
    {
        public FormListNomenclature()
        {
            InitializeComponent();
        }

        private void FormListNomenclatures_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.nomenclature". При необходимости она может быть перемещена или удалена.
            this.nomenclatureTableAdapter.Fill(this.dataSet.nomenclature);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formElementNomenclature = new FormElementNomenclature();
            formElementNomenclature.Show();
        }
    }
}
