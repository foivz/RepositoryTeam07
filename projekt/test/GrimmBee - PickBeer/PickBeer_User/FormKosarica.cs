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

        private void stavke_kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stavke_kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void FormKosarica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Pivo' table. You can move, or remove it, as needed.
            this.pivoTableAdapter.Fill(this.t07_DBDataSet.Pivo);
            // TODO: This line of code loads data into the 't07_DBDataSet.Stavke_kosarica' table. You can move, or remove it, as needed.
            this.stavke_kosaricaTableAdapter.FillByID(this.t07_DBDataSet.Stavke_kosarica,BrojNarudbe.brojNarudbe);
            

            
            
            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i=i+1)
            {
                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[4].FormattedValue.ToString());
                int zbroj = prvi *drugi;

                stavke_kosaricaDataGridView.Rows[i].Cells[5].Value = zbroj.ToString() + ",00 kn";
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString() + ",00 kn";
            
            

        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            T07_DBDataSet.KosaricaRow izmjenareda;
            izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);

            izmjenareda.Vrijeme = DateTime.Now;
            izmjenareda.Status = false;

            this.kosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);

            T07_DBDataSetTableAdapters.KosaricaTableAdapter kosarica = new T07_DBDataSetTableAdapters.KosaricaTableAdapter();

            kosaricaBindingSource.AddNew();
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

            BrojNarudbe.brojNarudbe = BrojNarudbe.brojNarudbe + 1;
            this.stavke_kosaricaTableAdapter.FillByID(this.t07_DBDataSet.Stavke_kosarica, BrojNarudbe.brojNarudbe);

            MessageBox.Show("Narudžba je zaprimljena");
        }

        private void stavke_kosaricaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            int redBrisanje = int.Parse(stavke_kosaricaDataGridView.CurrentRow.Cells[0].Value.ToString());
            int kolicina = int.Parse(stavke_kosaricaDataGridView.CurrentRow.Cells[3].Value.ToString());
            MessageBox.Show(redBrisanje.ToString() + "  " + kolicina.ToString());

            

            /*

            t07_DBDataSet.Stavke_kosarica.Rows[0].Delete();
            t07_DBDataSet.Stavke_kosarica.AcceptChanges();

            MessageBox.Show("Element izbrisan.");*/

            /*
            
            // Locate the row to delete.
            NorthwindDataSet.RegionRow oldRegionRow;
            oldRegionRow = northwindDataSet.Region.FindByRegionID(5);
                      
            // Delete the row from the dataset
            oldRegionRow.Delete();

            // Delete the row from the database 
            this.regionTableAdapter.Update(this.northwindDataSet.Region);*/

            /*
            foreach (DataGridViewRow item in this.stavke_kosaricaDataGridView.SelectedRows)
            {
                stavke_kosaricaDataGridView.Rows.RemoveAt(item.Index);
            }
             * 
            if (this.stavke_kosaricaDataGridView.SelectedRows.Count > 0)
            {
                stavke_kosaricaDataGridView.Rows.RemoveAt(this.stavke_kosaricaDataGridView.SelectedRows[0].Index);
            }*/

            

        }


    }
}
