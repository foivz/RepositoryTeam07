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
            FormStol frmStol = new FormStol();
            frmStol.ShowDialog();
            
            
            
            
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

        }
<<<<<<< HEAD

        private void proba_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBR_Click(object sender, EventArgs e)
        {
            FormRulet frmRulet = new FormRulet();
            frmRulet.ShowDialog();
        }
=======
>>>>>>> parent of df26571... Dorada aplikacije
    }
}
