using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("escriba el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("escriba el segundo valor:  ");
            b = Convert.ToDouble(Console.ReadLine());

            //SUMA DE VALORES            
            double resul_suma;
            resul_suma = a + b;
            Console.WriteLine("La suma de " + a + " mas " + b + " es " + resul_suma);

            //RESTA DE VALORES            
            double resul_resta;
            resul_resta = a - b;
            Console.WriteLine("La resta de " + a + " menos " + b + " es " + resul_resta);

            //MULTIPLICACION DE VALORES            
            double resul_mult;
            resul_mult = a * b;
            Console.WriteLine("La suma de " + a + " multiplicado " + b + " es " + resul_mult);

            //DIVISION DE VALORES            
            double resul_div;
            resul_div = a / b;
            Console.WriteLine("La division de " + a + " dividido " + b + " es " + resul_div);
        }
    }
}
