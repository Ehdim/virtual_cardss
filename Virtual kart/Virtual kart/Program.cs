using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_kart_ns;

namespace Virtual_kart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Username-i daxil edin");
            string username = Console.ReadLine();
            Kart virtual_kart = new Kart();
            if (username == "Ehdim")
            {
                Console.WriteLine(virtual_kart.CreatHesabNomresi());
            }
            else
            {
               DateTime b= virtual_kart.CreateBitmeMuddeti(1,2017);
                Console.WriteLine(b);
                Console.WriteLine("username sehvdir");
            }
            Console.ReadLine();
        }
    }
}
