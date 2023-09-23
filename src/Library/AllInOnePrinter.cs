using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
public class AllInOnePrinter
    {
        private IPrinter printer;

        public AllInOnePrinter(IPrinter printer)
        {
            this.printer = printer;
        }
        public void PrintRecipe(Recipe recipe)
        {
            string textToPrint = recipe.GetTextToPrint();
            printer.Print(textToPrint);
        }
    }
}

/* 
SRP: se aplica al dividir AllInOnePrinter para que no tenga la responsabilidad de saber donde imprimir. Esta responsabilidad se las da a 
consoleprinter y fileprinter, garantizando que cada clase tenga una unica responsabilidad.

Polimorfismo: se usa al crear la interfaz IPrinter y tener 2 implementaciones de esta que implementan el metodo print de diferente manera.
Permitiendo que ALLInOnePrinter interactue con diferentes implementaciones de IPrinter dependiendo de la instancia que se le pase.

LSP: La interfaz IPrinter garantiza que cualquier clase que la implementa pueda ser utilizada de maneera intercambiable en el contexto de 
AllInOnePrinter.
*/
