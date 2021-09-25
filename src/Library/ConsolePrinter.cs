using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    // esta operacion  es polimórfica porque es implementada por dos o más objetos de diferentes tipos.
    public class ConsolePrinter : IPrinter
{
    public void PrintTicket(Recipe receta)
    {
        Console.WriteLine(receta.GetTextToPrint());
    }
}
}