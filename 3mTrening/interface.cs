using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    public class Naszinterface : Inowyinterface
    {
        public int dodawanieczegos(int a, int b)
        {
            return a + b;
        }
        public int odejmowanieczegos(int a, int b)
        {
            return a - b;
        }
    }
    public interface Inowyinterface
    {
        int dodawanieczegos(int a, int b);

        int odejmowanieczegos(int a, int b);

    }
}
