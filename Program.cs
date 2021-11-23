
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTACION
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario, contraseña;
            int opcion, acumuladorRF, acumuladorMG, acumuladorAC, acumuladorN, acumuladorB, contadorP=0, contador=0, n;
            acumuladorRF = 0;
            acumuladorMG = 0;
            acumuladorAC = 0;
            acumuladorN = 0;
            acumuladorB = 0;
            Console.WriteLine("ingrese el numero de invercionistas que van a votar.");
            n = int.Parse(Console.ReadLine());
            for(contador=1;contador<=n;contador++)
            {
               
                Console.WriteLine("ingrese el usuario");
                usuario = Console.ReadLine();
                Console.WriteLine("ingrese la contraseña");
                contraseña = Console.ReadLine();
                Console.WriteLine("El usuario:" + usuario);
                Console.WriteLine("(1)Rodolfo Figueroa(2)Marcelo Gozo(3)Agustin Cejon(4)Blanco(5)Nulo");
                opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.WriteLine("Usted a votado por Rodolfo Figueroa.");
                    acumuladorRF++;
                }
                else
                    if (opcion == 2)
                {
                    Console.WriteLine("Usted a votado por Marcelo Gozo.");
                    acumuladorMG++;
                }
                else
                        if (opcion == 3)
                {
                    Console.WriteLine("Usted a votado por Agustin Cejom");
                    acumuladorAC++;
                }
                else
                            if (opcion == 4)
                {
                    Console.WriteLine("Usted voto en blanco");
                    acumuladorB++;
                }
                else
                                if (opcion == 5)
                {
                    Console.WriteLine("Usted a anulado el voto");
                    acumuladorN++;
                }
                contadorP++;
            }
            Console.WriteLine("Usted a terminado el voto con exito ");
            Console.WriteLine("Votos por Rodolfo Figueroa " + acumuladorRF);
            Console.WriteLine("Votos por Marcelo Gozo " + acumuladorMG);
            Console.WriteLine("Votos por Agustin Cejon " + acumuladorAC);
            Console.WriteLine("Votos en blanco" + acumuladorB);
            Console.WriteLine("Votos nulos " + acumuladorN);
            Console.WriteLine("Numero de sufragantes es " + contadorP);
            Console.ReadKey();//CODIGO COMPLETO
           
        }
    }
}
