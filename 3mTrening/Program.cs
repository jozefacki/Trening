using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class Program
    {
        static void Main(string[] args)
        {


            StreamReader SR = File.OpenText("C:/errorLog.txt");
            StringBuilder Dozaczytania = new StringBuilder();
            Dozaczytania.AppendLine(SR.ReadToEnd());

            Console.WriteLine(".");
            


            //Bryla nowabryla = new Bryla();
            //person imienazw = new person( "Tomuś" , "Jurkiewicz" );

            //user newUser = new user("Kasia","Hoppe"); // konstruktor
            //user newUser3 = new user("Anita", "L", 25, true, "Srubowa", "51-000", "Wrocław");
            //int i = 12;
            //i = i + 10;

            //List<user> listaUzytkownikow = new List<user>();

            //for(int j = 0; j < 5; j++)
            //{
            //    listaUzytkownikow.Add(new user("imie"+j.ToString(), "nazwisko"+j.ToString()));
            //}
            //user newUser2 = new user("Jarek", "G");




            //Bryla b = new Bryla();
            //Bryla c = b;

            //b.test = 4;

            //Console.WriteLine(b.test);
            //Console.WriteLine(c.test);
            //int y = 10;
            //int x = y;
            //y++;
            //Console.WriteLine(y);
            //Console.WriteLine(x);



            //List<string> Listatekstu = new List<string>();

            //Listatekstu.Add("qwe");
            //Listatekstu.Add("qwe2");
            //Listatekstu.Add("qwe3");

            //int wynikmetody = Liczba("qwe3", Listatekstu);
            //Console.WriteLine(wynikmetody);
            //foreach (string LT in Listatekstu)
            //{
            //    Console.WriteLine(wynikmetody);

            //}






            //int[] tablica4 = new int[100];


            //for (int i = 0; i < tablica4.Length; i++)
            //{
            //    tablica4[i]=i;
            //    Console.WriteLine(tablica4[i]);
            //}
            //Console.ReadLine();

            /*int[,]tablica3= new int [2,3];
            tablica3[0,0]=2;
            tablica3[0,1]=5;

            Console.WriteLine(tablica3[0,0]);
            Console.ReadLine();
            /*int[] tablica = new int[2];
            Console.WriteLine(tablica.Length);

            int[] tablica2 = new int[5] { 1, 2, 3, -5, 10 };
            Console.WriteLine(tablica2.Length);

            tablica2[2]= 100;

            for (int i = 0; i < tablica2.Length; i++)
            {
                Console.WriteLine(tablica2[i]);
            }
            Console.ReadLine();*/

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //while (i < 5);

            //const string s = "trening";
            //foreach (char c in s)
            //{
            //    Console.WriteLine(c);
            //}
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}

            // Modifikatory dostepu
            //      public
            //      private
            //      protected
            //      internal

            // Jak tworzymy metody
            // modyfikator dostepu, typ zwracany, nazwa metody, jej argumenty

            //int suma = Dodawanie(3, 6);
            //MetodaTreningowa(suma);
            //bool a = Sprawdzenie(10);
            //Console.WriteLine(a);
            //string slowo = Laczenie("Ala","ma","kota");
            //Console.WriteLine(slowo);

            //string slowo = KtoryDlugi("agdssdd","pcvs");
            //Console.WriteLine(slowo);

            //float srednia = SredniaArtymetycznaz2(3,4);

            //Console.WriteLine(srednia);

            Console.ReadKey();
        }
        public static void MetodaTreningowa(int suma)
        {

            Console.WriteLine(suma);
        }


        public static int Dodawanie(int x, int y)
        {
            return x + y;

        }

        public static bool Sprawdzenie(int x)
        {
            if (x > 100)
            {
                return true;
            }
            else
                return false;
        }

        public static string Laczenie(string t1, string t2, string t3)
        {
            return t1 + " " + t2 + " " + t3;
        }
        public static string KtoryDlugi(string L1, string L2)
        {
            if (L1.Length > L2.Length)
            {
                return L1;
            }
            else
            {
                return L2;
            }
        }
        public static int SredniaArtymetycznaz2(int a, int b)
        {
            return (a + b) % 2;
        }

        public static int Liczba(string a, List<string> Listatekstu)
        {
            return Listatekstu.IndexOf(a);
        }
    }
}
