using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
        public void Print(string text)
        {
            File.WriteAllText("Recipe.txt",text);
        }
    }
}