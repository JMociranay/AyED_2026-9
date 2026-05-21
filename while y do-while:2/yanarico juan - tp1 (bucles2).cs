using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto = 10000;
            bool salir = true;
            while (salir == true)
            {
                Console.WriteLine("Cajero Automatico");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. retirar dinero");
                Console.WriteLine("3. ver saldo actual");
                Console.WriteLine("4. salir");
                Console.Write("eliga la opcion que desee: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("ingrese el dinero que depositara: ");
                        int deposito = int.Parse(Console.ReadLine());
                        monto = monto + deposito;
                        break;

                    case 2:
                        Console.Write("ingrese el dinero que va a retirar: ");
                        int retiro = int.Parse(Console.ReadLine());
                        if (retiro > monto)
                        {
                            Console.WriteLine("el monto a retirar se excede al saldo actual");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            monto = monto - retiro;
                        }
                        break;
                    case 3:
                        Console.WriteLine("su saldo actual es $" + monto);
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        Console.WriteLine("salir del menu");
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("opcion no valido");
                        break;



                }


            }
        }
    }
}
