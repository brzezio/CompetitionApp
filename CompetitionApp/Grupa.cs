using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp
{
    public class Grupa
    {
        public PodGrupa[] podGrupy=new PodGrupa[0];
        public int liczbaPodGrup=0;
        public string nazwaGrupy;
        public int minWiek;
        public int maxWiek;

        public Grupa(int MinWiek, int MaxWiek, string nazwa)
        {
            minWiek = MinWiek;
            maxWiek = MaxWiek;
            nazwaGrupy = nazwa;
        }
        
        public void AddPodGrupa(PodGrupa podGrupa)
        {
            liczbaPodGrup++;
            PodGrupa[] newPodGrupy = new PodGrupa[liczbaPodGrup];
            newPodGrupy = podGrupy;
            newPodGrupy[liczbaPodGrup - 1] = podGrupa;
            podGrupy = newPodGrupy;
        }
    }
}
