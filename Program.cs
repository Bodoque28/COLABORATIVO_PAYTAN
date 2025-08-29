using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritmo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio=0;
            double preciofinal;

            Console.WriteLine("VENTA DE JUGOS");
            Console.WriteLine("1. NARANJA");
            Console.WriteLine("2. FRESA");
            Console.WriteLine("3. LUCUMA");
            Console.WriteLine("4. PAPAYA");
            Console.WriteLine("5. SURTIDO");
            Console.WriteLine("6. PIÑA");

            Console.WriteLine("SOLICITADO (NUM): ");
            int order = int.Parse( Console.ReadLine());

            Console.WriteLine("1. LARGE");
            Console.WriteLine("2. MEDIUM");
            Console.WriteLine("3. SMALL");
            Console.WriteLine("TAMAÑO(NUM):");
            int size = int.Parse(Console.ReadLine());
            if (size >= 4 || size <= 0)
            {
                Console.WriteLine("DIGITE UN NUMERO CORRECTO");
                return;
            }
            Console.WriteLine("1. EFECTIVO");
            Console.WriteLine("2. ELECTRONICO");
            Console.WriteLine("FORMA DE PAGA(NUM):");
            int bill = int.Parse(Console.ReadLine());

            switch (order)
            {
                case 1:

                    if (size == 1)
                    { precio = 15.50; }
                     else if (size == 2)
                    { precio = 12.00; }
                     else 
                    { precio = 10.50; }
                        break;
                case 2:
                    if (size == 1)
                    { precio = 17; }
                    else if (size == 2)
                    { precio = 13.70; }
                    else 
                    { precio = 11.50; }
                    break;
                case 3:
                    if (size == 1)
                    { precio = 14.20; }
                    else if (size == 2)
                    { precio = 11.20; }
                    else 
                    { precio = 9.70; }
                    break;
                case 4:
                    if (size == 1)
                    { precio = 10; }
                    else if (size == 2)
                    { precio = 8.50; }
                    else 
                    { precio = 6.50; }
                    break;
                case 5:
                    if (size == 1)
                    { precio = 20; }
                    else if (size == 2)
                    { precio = 17; }
                    else
                    { precio = 15; }
                    break;
                case 6:
                    if (size == 1)
                    { precio = 11.50; }
                    else if (size == 2)
                    { precio = 9.40; }
                    else 
                    { precio = 7.20; }
                    break;
                default:
                    Console.WriteLine("NUMERO NO VALIDO");
                    break;
            }

            Console.WriteLine("PRECIO: $" + precio);
            if (bill == 1)
            {
                preciofinal = precio * (1 - 0.08);
                Console.WriteLine("DESCUENTO (8%): $" + Math.Round((precio - preciofinal),2));
            }
            else if (bill == 2)
            {
                preciofinal = precio * (1 + 0.07);
                Console.WriteLine("RECARGO (7%): $" + Math.Round((preciofinal - precio), 2));
            }
            else
            {
                Console.WriteLine("NUMERO NO VALIDO");
                return;
            }

             Console.WriteLine("TOTAL: $" + Math.Round (preciofinal,2));
            
        }

    }
}

