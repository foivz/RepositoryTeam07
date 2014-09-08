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
    public partial class Glavni_izbornik : Form
    {
     
        public Glavni_izbornik()
        {
            InitializeComponent();
            
        }

        private void buttonCjenik_Click(object sender, EventArgs e)
        {
            FormCjenik frmCjenik = new FormCjenik();
            frmCjenik.ShowDialog();
        }

        
        private void buttonKosarica_Click(object sender, EventArgs e)
        {
            FormKosarica frmKos = new FormKosarica();
            frmKos.ShowDialog();
        }

        private void Glavni_izbornik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 't07_DBDataSet.MAX_ID_Kosarica' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 't07_DBDataSet.Kosarica' table. You can move, or remove it, as needed.
            this.kosaricaTableAdapter.Fill(this.t07_DBDataSet.Kosarica);


            T07_DBDataSetTableAdapters.KosaricaTableAdapter kosarica = new T07_DBDataSetTableAdapters.KosaricaTableAdapter();

            kosaricaBindingSource.AddNew();
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

            //MessageBox.Show("Stvorena kosarica");
            
            this.mAX_ID_KosaricaTableAdapter.Fill(this.t07_DBDataSet.MAX_ID_Kosarica);
            BrojNarudbe.brojNarudbe = int.Parse(ZadnjaNarudba.Text);
            
        }

        private void kosaricaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kosaricaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.t07_DBDataSet);

        }

        private void proba_Click(object sender, EventArgs e)
        {
            
        }
    }
}
