using System;

namespace CalculateFrom10ToAnotherOne
{
    public static class CheckArguments
    {
        public static bool CheckArgs(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Please send 2 parameters: a number in decimal notation and notation.");
                Console.WriteLine("Restart the program");
                return false;
            }
            else
            {
                int decimalNumber;
                int notation;
                bool isDecimalNumberParsed = int.TryParse(args[0], out decimalNumber);
                bool isNotationParsed = int.TryParse(args[1], out notation);

                if (!isDecimalNumberParsed || !isNotationParsed)
                {
                    Console.WriteLine("Please enter an int number in decimal notation and notation.");
                    Console.WriteLine("Restart the program");
                    return false;
                }
                else if (decimalNumber <= 0)
                {
                    Console.WriteLine("Numbers will be greater than 0.");
                    Console.WriteLine("Restart the program");
                    return false;
                }
                else if (notation > 20 || notation <= 1)
                {
                    Console.WriteLine("Notation will be greater than 1 and less than 20.");
                    Console.WriteLine("Restart the program");
                    return false;
                }
            }

            return true;
        }
    }
}
