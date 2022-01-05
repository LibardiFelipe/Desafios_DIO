using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExibeFrase
{
    internal class Program
    {
        // Frase que será exibida durante a execução do programa
        private const string _frase = "Digital Innovation One...";

        static void Main()
        {
            int letrasMostradas = 0;

            while (true)
            {
                if (letrasMostradas >= _frase.Length)
                {
                    letrasMostradas = 0;
                    Console.Clear();
                }
                         
                Console.Write(_frase[letrasMostradas]);

                letrasMostradas++;
                Thread.Sleep(50);
            }
        }
    }
}
