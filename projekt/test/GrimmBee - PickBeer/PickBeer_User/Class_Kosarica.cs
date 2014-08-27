using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBeer_User
{
    public class Class_Kosarica
    {
        

        public List<Artikli> artikli {get;set;}

        public void Dodaj_artikl(int ID)
        {
            Artikli artikl = new Artikli(ID);
            artikli.Add(artikl);
        }
    }
}
