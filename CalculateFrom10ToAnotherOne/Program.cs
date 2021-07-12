using System;

namespace CalculateFrom10ToAnotherOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool areArgsCorrect = ArgumentsChecker.CheckArgs(args);

            if (areArgsCorrect)
            {
                int decimalNumber = Int32.Parse(args[0]);
                int notation = Int32.Parse(args[1]);

                string numberRepresentation = Convertor.ConvertNumberToAnotherNotation(decimalNumber, notation);
                Console.WriteLine(numberRepresentation);
            }

            Console.ReadKey();
        }
    }
}
