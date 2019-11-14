using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace galavićMarkoPetljeOcijene
{
    class Program
    {
        static void Main(string[] args)
        {
            int ocijena;
            float prosjek;
            float brojOcijena = 0;
            int zbrojOcijena = 0;
               do
          {
                Console.WriteLine("Upišite ocijenu");
                ocijena = Convert.ToInt16(Console.ReadLine());


                if (ocijena == 1)
                {
                    prosjek = 1;
                    break;
                }
                else if (ocijena > 5 || ocijena < 0)
                {
                    Console.WriteLine("Pogrešan unos. Unesite ponovo.");
                }
                else if(ocijena != 0)
                {
                    brojOcijena++;
                    zbrojOcijena += ocijena;
                }

                prosjek = zbrojOcijena / brojOcijena;
            }
                while (ocijena != 0) ;
            Console.WriteLine("Prosjek ocjena je " + prosjek);

          



            Console.ReadKey();

         }
    }
}
