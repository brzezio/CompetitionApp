using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionApp
{
    public class Zawodnik
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        public double waga;

        public Zawodnik(string Imie,string Nazwisko, int Wiek, double Waga)
        {
            imie = Imie;
            nazwisko = Nazwisko;
            wiek = Wiek;
            waga = Waga;
        }
    }
}
