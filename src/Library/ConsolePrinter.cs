using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}