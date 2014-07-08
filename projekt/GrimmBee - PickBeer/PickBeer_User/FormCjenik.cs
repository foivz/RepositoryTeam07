using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickBeer_User
{
    public partial class FormCjenik : Form
    {
        public FormCjenik()
        {
            InitializeComponent();
        }

        private void pivoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pivoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void FormCjenik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Drzava_Select' table. You can move, or remove it, as needed.
            this.drzava_SelectTableAdapter.Fill(this.t07_DBDataSet.Drzava_Select);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            pictureBoxCjenik.ImageLocation = pivoDataGridViewCjenik.CurrentRow.Cells[12].Value.ToString();
        }

        private void drzava_podrijetlaComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String Drz = drzava_podrijetlaComboBox.SelectedValue.ToString();
            this.pivoTableAdapter.FillByDrzava(t07_DBDataSet.Pivo, Drz);
        }

        private void pivoDataGridViewCjenik_SelectionChanged(object sender, EventArgs e)
        {
            if (pivoDataGridViewCjenik.RowCount > 0)
            {
                pictureBoxCjenik.ImageLocation = pivoDataGridViewCjenik.CurrentRow.Cells[12].Value.ToString();
            }
        }

        private void buttonSve_Click(object sender, EventArgs e)
        {
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
        }

        
    }
}
