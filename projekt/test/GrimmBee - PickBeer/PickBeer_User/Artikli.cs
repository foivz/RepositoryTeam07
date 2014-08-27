using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickBeer_User
{
    public class Artikli
    {
        private int ID{get;set;}
        public int Kolicina { get; set; }

        public Artikli(int ID)
        {
            this.ID = ID;
        }
    }
}
