using System;
using System.Windows.Forms;


namespace CourseBD
{
    public partial class FormElementNomenclature : Form
    {


        public FormElementNomenclature()
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
