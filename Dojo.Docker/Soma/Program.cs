using System;

namespace Soma
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var n1 = int.Parse(args[0]);
                var n2 = int.Parse(args[1]);
                
                Console.WriteLine(n1 + n2);
            }
            catch
            {
                Console.WriteLine(Figgle.FiggleFonts.Standard.Render("ESTÁ FAZENDO ERRADO ANIMAL"));
            }
        }
    }
}