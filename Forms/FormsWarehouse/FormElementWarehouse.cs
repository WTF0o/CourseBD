using System;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsWarehouse
{
    public partial class FormElementWarehouse : Form
    {
        public FormElementWarehouse()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
