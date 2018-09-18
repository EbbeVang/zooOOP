using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace zooOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kat k = new Kat();
            k.navn = "Molly";

            Dyr dyr = new Dyr();
            dyr.Tam = true;
            dyr.Tam = false;
            Console.WriteLine(dyr.Tam);
           
            /*
            // create instance of  Hest
            Hest minHest = new Hest();
            Hest minAndenHest = new Hest();

            minHest.Run();
            minAndenHest.Run();
            */
        }
    }
}
