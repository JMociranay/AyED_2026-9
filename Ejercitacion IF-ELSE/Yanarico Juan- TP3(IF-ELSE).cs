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
            double AñosLuz, combustible, faltante;
            Console.WriteLine("ingrese la distacia hacia su destino en Años Luz: ");
            AñosLuz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de combustible en litros: ");
            combustible = Convert.ToDouble(Console.ReadLine());
            if (AñosLuz * 12 <= combustible)
            {
                Console.WriteLine("Cálculos precisos. Saltando al hiperespacio");
            }
            else
            {
                faltante = (AñosLuz * 12) - combustible;
                Console.WriteLine("Peligro: Combustible insuficiente. Faltan  " + faltante + " litros");
            }
        }
    }
}
