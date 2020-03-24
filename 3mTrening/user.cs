using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class user
    {
        string imie;
        string nazwisko;
        int wiek;
        bool czyAbonament;
        string ulica;
        string kod;
        string miejscowosc;

        public user (string imie1, string nazwisko1)
        {
            imie = imie1;
            nazwisko = nazwisko1;
        }

        public user (string imie1, string nazwisko1,int wiek1, bool czyAbonament1, string ulica1, string kod1, string miejscowosc1)
        {
            imie = imie1;
            nazwisko = nazwisko1; 
            wiek = wiek1;
            czyAbonament = czyAbonament1;
            ulica = ulica1;
            kod = kod1;
            miejscowosc = miejscowosc1;

        }
    }

    
}
