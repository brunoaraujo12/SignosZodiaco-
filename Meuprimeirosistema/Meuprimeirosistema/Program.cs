using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuprimeirosistema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Signo signo= new Signo();
            signo.nome = "Libra";

            Console.WriteLine("Seu signo é " +signo.nome);
            Console.ReadLine();


        }
    }
}
