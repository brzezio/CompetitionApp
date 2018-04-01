using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp
{
    public class PodGrupa
    {
        public Zawodnik[] zawodnicy=new Zawodnik[0];
        public int liczbaZawodnikow=0;
        public string nazwaPodGrupy;
        public int minWaga;
        public int maxWaga;

        public PodGrupa(int MinWaga, int MaxWaga,string nazwa)
        {
            minWaga = MinWaga;
            maxWaga = MaxWaga;
            nazwaPodGrupy = nazwa;
        }

        public void AddZawodnik(Zawodnik zawodnik)
        {
            liczbaZawodnikow++;
            Zawodnik[] newZawodnicy = new Zawodnik[liczbaZawodnikow];
            newZawodnicy = zawodnicy;
            newZawodnicy[liczbaZawodnikow - 1] = zawodnik;
            zawodnicy = newZawodnicy;
        }
    }
}
