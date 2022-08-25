using System;

namespace PulaSapo
{
    class Program
    {
        static void Main(string[] args)
        {
            var entrada= Console.ReadLine().Split(" ");
            var alturaDoPulo= int.Parse(entrada[0]);
            var numeroDeCanos= int.Parse(entrada[1]);

            string[] pulo = Console.ReadLine().Split(' ');
            int[] pulos = Array.ConvertAll(pulo, int.Parse);

            bool controlador = true;

            for (int i = 0; i < (numeroDeCanos - 1); i++) {
               if ((pulos[i] - pulos[i + 1]) < (-alturaDoPulo))
                 controlador = false;
              else if ((pulos[i] - pulos[i + 1]) > alturaDoPulo)
                controlador = false;
            }

            Console.WriteLine(Resultado(controlador));
        }

        public static string Resultado(bool controlador)
        {
            return (controlador)? "YOU WIN": "GAME OVER";
        }

    }
}
