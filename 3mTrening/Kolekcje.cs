using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class Kolekcje
    {
        List<String> listakolekcji;
        Dictionary<string,int> slownikkolekcji; 

        public Kolekcje()
        {
            listakolekcji = new List<string>();
            slownikkolekcji = new Dictionary<string, int>();
        }

        public int iloscwliscie()
        {
            return listakolekcji.Count();
        }

        public void dodawanieelementudolisty(string a)
        {
            listakolekcji.Add(a);
        }
        public void dodawaniedoslownika()
        {
            slownikkolekcji.Add("wyraz1", 100);
            slownikkolekcji.Add("wyraz2", 2);
          //  slownikkolekcji.Add("wyraz2", 2);  //niedziała bo ...
        }
        public int iloscwslowniku()
        {
            return slownikkolekcji.Count();
        }
        public void dodawaniedoslownika2(string klucz,int wartosc1)
        {
            //slownikkolekcji.Add(z,10);
            if (slownikkolekcji.ContainsKey(klucz))
            {
                slownikkolekcji[klucz] = wartosc1;

            }
            else
            {
                slownikkolekcji.Add(klucz, wartosc1);
            }
        }
        public void wartoscpodkluczem(string wyraz)
        {
            if(slownikkolekcji.ContainsKey(wyraz))
            {
                int value = slownikkolekcji[wyraz];
                Console.WriteLine(value);
            } 
        }

        public void wypiszliste()
        {
            foreach (string item in listakolekcji)
            {
                Console.WriteLine(item);
            }
        }
        public void wypiszslownik()
        {
            foreach (KeyValuePair<string,int> pair in slownikkolekcji)
            {
                Console.WriteLine(pair.Key +" "+ pair.Value);
            }
        }

        //Kolekcje slownikkolekcji1 = new Kolekcje();
        //slownikkolekcji1.dodawaniedoslownika();
        //Console.WriteLine(slownikkolekcji1.iloscwslowniku());

        //slownikkolekcji1.wartoscpodkluczem("wyraz1");
        //slownikkolekcji1.wypiszslownik();

        //slownikkolekcji1.dodawaniedoslownika2("wyraz123",123);
        //slownikkolekcji1.wypiszslownik();

        //Kolekcje kolekcj1 = new Kolekcje();
        //int wielkosclisty = kolekcj1.iloscwliscie();

        //Console.WriteLine(kolekcj1.iloscwliscie());

        //kolekcj1.dodawanieelementudolisty("tekst1");
        //Console.WriteLine(kolekcj1.iloscwliscie());
    }
}
