using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{// esta operacion  es polimórfica porque es implementada por dos o más objetos de diferentes tipos.
public class FilePrinter : IPrinter
{
    public void PrintTicket(Recipe receta)
    {
        File.WriteAllText("Ticket.txt", receta.GetTextToPrint());
    }
}
}