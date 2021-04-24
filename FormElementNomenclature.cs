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
    public partial class FormElementNomenclature : Form
    {
        public string id = "";
        public string name = "";
        public string manufacturer = "";
        public string country = "";

        public FormElementNomenclature()
        {
            InitializeComponent();

        }

        public FormElementNomenclature(string id = "", string name = "", string manufacturer = "", string country = "")
        {
            InitializeComponent();
            textBoxId.Text = id;
            textBoxName.Text = name;
            textBoxManufacturer.Text = manufacturer;
            textBoxCountry.Text = country;

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormElementNomenclature_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
