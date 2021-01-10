using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            int indexNo;
            string[] sehirler = { "Eskişehir", "İstanbul", "İzmir", "Diyarbakır", "Sivas", "Edirne", "Bursa", "Afyon", "Malatya", "Tekirdag", "Ankara" };
            Console.WriteLine("Bir şehir giriniz");
            string girilensehir = Console.ReadLine();

            bool varMi = false;
            for (int i = 0; i < sehirler.Length; i++)
            {
                if (sehirler[i] == girilensehir)
                {
                    Console.WriteLine($"Aranılan şehir {girilensehir} ve indeksi= {i}");
                    varMi = true;
                    break;
                }
            }

            if (!varMi)
            {
                Console.WriteLine("Listede böyle bir şehir bulunmamaktadır.");
                
            }
            Console.ReadLine();
        }
    }
}
