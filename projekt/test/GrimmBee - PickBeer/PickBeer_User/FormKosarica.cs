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
    public partial class FormKosarica : Form
    {
        public FormKosarica()
        {
            InitializeComponent();



        }

        private void kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void FormKosarica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Pregled_narudbe' table. You can move, or remove it, as needed.
            this.pregled_narudbeTableAdapter.Fill(this.t07_DBDataSet.Pregled_narudbe);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.Fill(this.t07_DBDataSet.Stavke_kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);


            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i++)
            {
                sum = sum +  int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[4].Value.ToString());
            }

            txtUkupno.Text = sum.ToString();
        }

        private void stavke_kosaricaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonNaruci_Click(object sender, EventArgs e)
        {

            
            



           

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
