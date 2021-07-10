using System;

namespace CalculateFrom10ToAnotherOne
{
    public class ConsoleWriter
    {
        public static void PrintNumberRepresentation(int decimalNumber, int notation)
        {
            string numberRepresentation = Convertor.ConvertNumberToAnotherNotation(decimalNumber, notation);
            Console.WriteLine(numberRepresentation);
         }
    }
}
