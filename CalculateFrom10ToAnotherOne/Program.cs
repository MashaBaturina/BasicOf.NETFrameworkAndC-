using System;
using System.Collections.Generic;

namespace CalculateFrom10ToAnotherOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool areArgsCorrect = CheckArguments.CheckArgs(args);

            if (areArgsCorrect)
            {
                int decimalNumber = Int32.Parse(args[0]);
                int notation = Int32.Parse(args[1]);

                List<int> total = Convertor.ConvertNumberToAnotherNotation(decimalNumber, notation);

                ConsoleWriter.PrintNumberRepresentation(total);
            }

            Console.ReadKey();
        }
    }
}
