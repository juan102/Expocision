using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad = 0;
            string tipo = "";
            IPrimitiva Calidad = null;
            double total = 0;

            Console.WriteLine("1-barato, 2-normal");
            tipo = Console.ReadLine();


            if (tipo == "1")
                Calidad = new Barato();
            if (tipo == "2")
                Calidad = new Normal();

            Console.WriteLine("Cuantos juguete se va a producir");
            Cantidad = Convert.ToInt32(Console.ReadLine());

            Algoritmo Produccion = new Algoritmo();
            total = Produccion.Metodotemplate(Calidad, Cantidad);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("El Total es {0}", total);

        }
    }
}
