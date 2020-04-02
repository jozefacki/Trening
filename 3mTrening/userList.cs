using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class userList
    {
        List<user> nowaLista;

        public userList()
        {
            nowaLista = new List<user>();
        }

        public List<user> zwrocPlec (bool plec)
        {
            return nowaLista.Where(y => y.plec == plec).ToList();
        
        }

        public List<user> zrocImionaA (string pierwszaLitera)
        {
            var i = nowaLista.FindAll(y => y.imie.StartsWith(pierwszaLitera));
            return i;
        }

        public List<user> zrocWiek(int wiek)
        {
            var i = nowaLista.FindAll(y => y.wiek > wiek);
            return i;
        }

        public void dodajUser(user user)
        {
            nowaLista.Add(user);
        }

    }
}
