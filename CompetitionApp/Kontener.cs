using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp
{
    public class Kontener
    {
        public Grupa[] grupy=new Grupa[0];
        public int liczbaGrup=0;

        public Kontener() { }

        public void AddGrupa(Grupa grupa)
        {
            liczbaGrup++;
            Grupa[] newGrupy = new Grupa[liczbaGrup];
            newGrupy = grupy;
            newGrupy[liczbaGrup - 1] = grupa;
            grupy = newGrupy;
        }
    }
}
