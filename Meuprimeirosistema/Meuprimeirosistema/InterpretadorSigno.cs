using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meuprimeirosistema
{
    internal class InterpretadorSigno
    {
        
        private Signo[] signos = new Signo[12];
        //construtor para executar sempre que a classe for instanciada 
        public InterpretadorSigno ()
        {
            signos[0] = new Signo { diaInicial = 20, mesInicial = 1, diaFim = 18, mesFim = 2, nome = "AQUARIO", caracteristicas = "CAMUS" };
            signos[1] = new Signo { diaInicial = 19, mesInicial = 2, diaFim = 20, mesFim = 3, nome = "PEIXES", caracteristicas = "AFRODITE" };
            signos[2] = new Signo { diaInicial = 21, mesInicial = 3, diaFim = 19, mesFim = 4, nome = "ARIES", caracteristicas = "MU" };
            signos[3] = new Signo { diaInicial = 20, mesInicial = 4, diaFim = 20, mesFim = 5, nome = "TOURO", caracteristicas = "ALDEBARAN" };
            signos[4] = new Signo { diaInicial = 21, mesInicial = 5, diaFim = 21, mesFim = 6, nome = "GEMEOS", caracteristicas = "SAGA" };
            signos[5] = new Signo { diaInicial = 22, mesInicial = 6, diaFim = 21, mesFim = 7, nome = "CANCER", caracteristicas = "MASCARA DA MORTE" };
            signos[6] = new Signo { diaInicial = 23, mesInicial = 7, diaFim = 22, mesFim = 8, nome = "LEÃO", caracteristicas = "AIOLIA" };
            signos[7] = new Signo { diaInicial = 23, mesInicial = 8, diaFim = 22, mesFim = 9, nome = "VIRGEM", caracteristicas = "SHAKA" };
            signos[8] = new Signo { diaInicial = 23, mesInicial = 9, diaFim = 22, mesFim = 10, nome = "LIBRA", caracteristicas = "DOHKO" };
            signos[9] = new Signo { diaInicial = 23, mesInicial = 10, diaFim = 22, mesFim = 11, nome = "ESCORPIÃO", caracteristicas = "MILO" };
            signos[10] = new Signo { diaInicial = 22, mesInicial = 11, diaFim = 21, mesFim = 12, nome = "SARGITARIO", caracteristicas = "AIOLOS" };
            signos[11] = new Signo { diaInicial = 22, mesInicial = 12, diaFim = 19, mesFim = 1, nome = "CAPRICORNIO", caracteristicas = "SHURA" };
      
        }
        public Signo Interpretar(int dia, int mes)
        {
            Signo signo = null;

            for (int i = 0; i < signos.Length; i++)
            {
                if ((dia >= signos[i].diaInicial && mes == signos[i].mesInicial ) || (dia <= signos[i].diaFim && mes == signos[i].mesFim)) {
                    signo = signos[i];
                    
                }

            
            }
            return signo;
        }


    }
}
