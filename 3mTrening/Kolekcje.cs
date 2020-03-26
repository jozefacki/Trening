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
        public void dodawaniedoslownika2(string z)
        {
            slownikkolekcji.Add(z,10);
            if (slownikkolekcji.ContainsKey(z))
            {
               // slownikkolekcji[z];

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


    }
}
