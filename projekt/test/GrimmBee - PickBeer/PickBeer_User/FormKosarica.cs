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
        int narudba;
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
<<<<<<< HEAD
<<<<<<< HEAD
            this.stavke_kosaricaTableAdapter.FillByID(this.t07_DBDataSet.Stavke_kosarica,BrojNarudbe.brojNarudbe);
=======
            this.stavke_kosaricaTableAdapter.FillByIDgrup(this.t07_DBDataSet.Stavke_kosarica,BrojNarudbe.brojNarudbe);
>>>>>>> origin/master
            
=======
            this.stavke_kosaricaTableAdapter.Fill(this.t07_DBDataSet.Stavke_kosarica);
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);

>>>>>>> parent of df26571... Dorada aplikacije

            int sum = 0;
            for (int i = 0; i < stavke_kosaricaDataGridView.Rows.Count; i++)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[4].FormattedValue.ToString());
                int zbroj = prvi *drugi;

                stavke_kosaricaDataGridView.Rows[i].Cells[5].Value = zbroj.ToString() + ",00 kn";
=======
                int prvi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[2].Value.ToString());
                int drugi = int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[3].FormattedValue.ToString());
                int zbroj = prvi *drugi ;
                
                stavke_kosaricaDataGridView.Rows[i].Cells[4].Value = zbroj.ToString()+",00 kn";
>>>>>>> origin/master
                sum = sum + zbroj;
            }

            txtUkupno.Text = sum.ToString()+",00 kn";
            
            

=======
                sum = sum +  int.Parse(stavke_kosaricaDataGridView.Rows[i].Cells[4].Value.ToString());
            }

            txtUkupno.Text = sum.ToString();
>>>>>>> parent of df26571... Dorada aplikacije
        }

        private void stavke_kosaricaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
            T07_DBDataSet.KosaricaRow izmjenareda;
            izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);
=======
            if (stavke_kosaricaDataGridView.Rows.Count > 0)
            {
                T07_DBDataSet.KosaricaRow izmjenareda;
                izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);
>>>>>>> origin/master

                izmjenareda.Vrijeme = DateTime.Now;
                izmjenareda.Status = false;

                this.kosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);

                T07_DBDataSetTableAdapters.KosaricaTableAdapter kosarica = new T07_DBDataSetTableAdapters.KosaricaTableAdapter();

                kosaricaBindingSource.AddNew();
                this.Validate();
                this.kosaricaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

                txtUkupno.Text = "0,00 kn";
                BrojNarudbe.brojNarudbe++;
                this.stavke_kosaricaTableAdapter.FillByID(this.t07_DBDataSet.Stavke_kosarica, BrojNarudbe.brojNarudbe);

                BrojNarudbe.staraNarudba = 1;

                MessageBox.Show("Narudžba je zaprimljena");
            }
            else
                MessageBox.Show("Košarica je prazna");
        }

        private void btnPonovi_Click(object sender, EventArgs e)
        {
            if (BrojNarudbe.staraNarudba == 1)
            {

                T07_DBDataSet.KosaricaRow izmjenareda;
                izmjenareda = t07_DBDataSet.Kosarica.FindByID_kosarica(BrojNarudbe.brojNarudbe);

                izmjenareda.Vrijeme = DateTime.Now;
                izmjenareda.Status = false;

                this.kosaricaTableAdapter.Update(this.t07_DBDataSet.Kosarica);
                MessageBox.Show("Runda je ponovljena.");

            }
            else
                MessageBox.Show("Nemate kreiranih narudžbi.");

        }
=======

        }

        private void buttonNaruci_Click(object sender, EventArgs e)
        {

            
            


>>>>>>> parent of df26571... Dorada aplikacije

           

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
=======
            /*
>>>>>>> origin/master
            int redBrisanje = int.Parse(stavke_kosaricaDataGridView.CurrentRow.Cells[0].Value.ToString());
            int kolicina = int.Parse(stavke_kosaricaDataGridView.CurrentRow.Cells[3].Value.ToString());


            foreach (DataGridViewRow item in this.stavke_kosaricaDataGridView.SelectedRows)
            {
                stavke_kosaricaDataGridView.Rows.RemoveAt(item.Index);
            }

            /*
            t07_DBDataSet.Stavke_kosarica.Rows[1].Delete();
            t07_DBDataSet.Stavke_kosarica.AcceptChanges();*/


            /*
            // Locate the row to delete.
            NorthwindDataSet.RegionRow oldRegionRow;
            oldRegionRow = northwindDataSet.Region.FindByRegionID(5);
            
            
                          
            // Delete the row from the dataset
            oldRegionRow.Delete();

            // Delete the row from the database 
            this.regionTableAdapter.Update(this.northwindDataSet.Region);*/
        }

<<<<<<< HEAD

=======
            
        }
>>>>>>> parent of df26571... Dorada aplikacije
=======
        
>>>>>>> origin/master
    }
}
