using System;
using System.Windows.Forms;

namespace CourseBD.Forms.FormsCurrencies
{
    public partial class FormElementCurrencies : Form
    {
        public FormElementCurrencies()
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
