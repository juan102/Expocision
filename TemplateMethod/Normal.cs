using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Normal : IPrimitiva
    {
        public double Decorar(int Cantidad)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hacer {0} veces ",Cantidad);
            Console.WriteLine("Pintar Logotipo");
            Console.WriteLine("Poner Brillos");
            Console.WriteLine("Adicionar Cromos");
            return 7.50 * Cantidad;
        }

        public double Empacar(int Cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hacer {0} veces ", Cantidad);
            Console.WriteLine("Preparar Caja");
            Console.WriteLine("Poner Instructivo");
            Console.WriteLine("Poner Garantia");
            Console.WriteLine("Sellar Caja");
            return 12.50 * Cantidad;
        }
    }
}
