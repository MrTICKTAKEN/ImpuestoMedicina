using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoMedicina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es el precio de tu producto a cotizar?");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿El producto es medicina? ");
            string respuesta = Console.ReadLine().ToLower();

            double impuesto = 0.0;

            if (respuesta == "no")
            {

                impuesto = precio * 0.16;
            }

            double precioTotal = precio + impuesto;
            Console.WriteLine($"El impuesto a pagar es de: {impuesto:C}");
            Console.WriteLine($"El precio total a pagar es de: {precioTotal:C}");
        }
    }
}
