using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Barato : IPrimitiva
    {
        public double Decorar(int Cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i=0; i<Cantidad ;i++)
            {
                Console.WriteLine("Pegar Etiqueta");
            }
            return 1.5 * Cantidad;
        }

        public double Empacar(int Cantidad)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < Cantidad; i++)
            {
                Console.WriteLine("Meter En La Bolsa");
            }
            return 0.25 * Cantidad;
        }
    }
}
