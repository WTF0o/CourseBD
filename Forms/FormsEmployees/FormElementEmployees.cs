using System;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsEmployees
{
    public partial class FormElementEmployees : Form
    {
        public FormElementEmployees()
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
