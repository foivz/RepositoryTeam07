using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrimmBee___RateBeer
{
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);

        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet11.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet11.Pivo);
            pictureBoxUpdate.ImageLocation = pivoDataGridViewUpdate.CurrentRow.Cells[10].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet11);
            MessageBox.Show("Enty updated");
        }
    }
}
