using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            String sexo;
            double edad;
            Console.Write("ingrese su sexo (M si es masculino) (F si es femenino): ");
            sexo = Console.ReadLine();
            Console.Write("ingrese su edad: ");
            edad = Convert.ToDouble(Console.ReadLine());

            if ((sexo == "F" && edad >= 65 ) || ( sexo == "M" && edad >= 60))
            {
                Console.WriteLine("puede iniciar el tramite jubilatorio");
            }


        }
    }
}
