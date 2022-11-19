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
            string dia;
            string mes;

            Console.WriteLine("Qual dia você nasceu? ");
            dia = Console.ReadLine();

            Console.WriteLine("Em qual mes você nasceu");
            mes = Console.ReadLine();

            int diaInt = 0;
            int mesInt = 0;

            try
            {
                 diaInt = Convert.ToInt32(dia);
                 mesInt = Convert.ToInt32(mes);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }

            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(diaInt, mesInt);

            if (signo != null)
            {
                Console.WriteLine("Seu signo é: " + signo.nome + " DE " + signo.caracteristicas);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não existe esse signo nas casas do zodiaco");
                
            }
            Console.ReadLine();
        }
    }
}
