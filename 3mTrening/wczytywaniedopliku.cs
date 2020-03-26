using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3mTrening
{
    class wczytywaniedopliku
    {

        public wczytywaniedopliku()
        {
            StringBuilder nowystringbuilder = new StringBuilder();
            nowystringbuilder.AppendLine("---------------------Error Info--------------------------");
            nowystringbuilder.AppendLine("data" + DateTime.Now.ToString());

            File.WriteAllText("C:/errorLog.txt", nowystringbuilder.ToString());
        }

    }
}
