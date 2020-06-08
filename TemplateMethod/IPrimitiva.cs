using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    interface IPrimitiva
    {
        double Decorar(int Cantidad);
        double Empacar(int Cantidad);
    }
}
