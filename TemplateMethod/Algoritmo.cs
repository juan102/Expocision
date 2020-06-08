using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class Algoritmo
    {


        public double Metodotemplate(IPrimitiva tipo , int Cantidad)
        {
            double total = 0;
            //Se Crea El Juguete
            total += CrearJuguete(Cantidad);

            //Lo Decoramos
            total += tipo.Decorar(Cantidad);

            //Verificamos Calidad
            Calidad();

            //Empacamos
            total += tipo.Empacar(Cantidad);

            return total;

        }


        private double CrearJuguete(double Cantidad)
        {
            Console.WriteLine("Estamos creando {0} Jugetes ", Cantidad);
            return 16.50 * Cantidad;
        }

        private void Calidad()
        {
            Console.WriteLine("Pasa Control De Calidad");
        }
    }
}
