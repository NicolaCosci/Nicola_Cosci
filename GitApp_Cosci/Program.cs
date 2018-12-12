using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitApp_Cosci
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato; int num = 255;risultato = "";
            Console.WriteLine("inserisci un numero in input");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>1)
            {
                int resto = num % 2;
                risultato = Convert.ToString(num) + risultato;
                Console.WriteLine($"il numero binario è{risultato}");

            }
        } 
    }
}
