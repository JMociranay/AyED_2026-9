using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador_neg = 0;
            int contador_pos = 0;
            int contador_cero = 0;
            bool finalizar = true;

            while (finalizar == true)
            {
                Console.Write("ingrese un numero o si quiere finalizar presione (X) O (n) :");
                string opcion = Console.ReadLine();
                if ((opcion == "X") || (opcion == "n"))
                {
                    finalizar = false;
                }
                else
                {
                    int numero = Convert.ToInt32(opcion);
                    if (numero > 0)
                    {
                        contador_pos++;
                    }
                    else if (numero < 0)
                    {
                        contador_neg++;
                    }
                    else
                    {
                        contador_cero++;

                    }
                }
            }
            Console.WriteLine("cantidad de numero positivos: "+ contador_pos);
            Console.WriteLine("cantidad de numero negativos: "+ contador_neg);
            Console.WriteLine("cantidad de cero: "+ contador_cero);
        }
    }
}
