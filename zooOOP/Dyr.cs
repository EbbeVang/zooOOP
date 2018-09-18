using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    // super-klassen alle dyr arver fra....
    class Dyr
    {
        public String navn;
        public int year;
        protected bool tam;

        public bool Tam
        {
            get { return tam; }
            set
            {
                if (tam == true) tam = true;
                if (tam == false) tam = value;
            }
        }
    }
}
