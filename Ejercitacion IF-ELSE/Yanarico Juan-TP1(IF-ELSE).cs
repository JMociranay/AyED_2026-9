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
            double peso_carga;
            Console.WriteLine("ingrese el peso de la carga en KG para evitar problemas al despegar: ");
            peso_carga = Convert.ToDouble(Console.ReadLine());
            if (peso_carga < 5000)
            {
                
                Console.WriteLine("Despegue autorizado.Buen viaje, Mando");
            }
            else
            {
                Console.WriteLine("Alerta: Exceso de peso.Debes descargar "+ (peso_carga - 5000) +" kg para despegar");

            }

        }
    }
}
