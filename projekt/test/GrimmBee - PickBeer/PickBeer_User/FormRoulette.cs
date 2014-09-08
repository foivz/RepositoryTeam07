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
    public partial class FormRoulette : Form
    {
        public FormRoulette()
        {
            InitializeComponent();
        }

        private void FormRoulette_Load(object sender, EventArgs e)
        {
           /*
            // TODO: This line of code loads data into the 't07_DBDataSet.Random_Drzava' table. You can move, or remove it, as needed.
            this.random_DrzavaTableAdapter.Fill(this.t07_DBDataSet.Random_Drzava);
            label1.Text = drzava_podrijetlaTextBox.Text;
            // TODO: This line of code loads data into the 't07_DBDataSet.Roulette' table. You can move, or remove it, as needed.
            this.rouletteTableAdapter.FillByDrzava(this.t07_DBDataSet.Roulette,label1.Text);
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.random_DrzavaTableAdapter.Fill(this.t07_DBDataSet.Random_Drzava);
            timer1.Start();
            ime_pivaTextBox.Text = "█" ;
            cijenaTextBox.Text = "█";
            volumenTextBox.Text = "█";
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            ime_pivaTextBox.Text = ime_pivaTextBox.Text + "█";
            cijenaTextBox.Text = cijenaTextBox.Text + "█";
            volumenTextBox.Text = volumenTextBox.Text + "█";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            string drzava = drzava_podrijetlaTextBox.Text;
            this.rouletteTableAdapter.FillByDrzava(this.t07_DBDataSet.Roulette, drzava);
            string slika = slikaTextBox.Text;
            pictureBoxRoulette.ImageLocation = slika;
            timer1.Stop();
        }

       
    }
}
