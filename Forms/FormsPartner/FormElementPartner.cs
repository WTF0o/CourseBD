using System;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsPartner
{
    public partial class FormElementPartner : Form
    {
        public FormElementPartner()
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
