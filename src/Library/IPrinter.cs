using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{    // implementamos esta interfaz porque  esta operacion  es polimórfica porque es implementada por dos o más objetos de diferentes tipos.
    public interface IPrinter
    {
        void PrintTicket(Recipe receta);
    }
}