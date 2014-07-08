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
    }
}
