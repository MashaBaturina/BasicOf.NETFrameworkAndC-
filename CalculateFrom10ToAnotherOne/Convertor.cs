using System.Collections.Generic;

namespace CalculateFrom10ToAnotherOne
{
    public class Convertor
    {       
        public static List<int> ConvertNumberToAnotherNotation(int decimalNumber, int notation)
        {
            List<int> numberRepresentation = new List<int>();

            int i = 0;

            while (decimalNumber >= 1)
            {
                int mod = decimalNumber % notation;
                numberRepresentation.Add(mod);
                i++;

                decimalNumber = decimalNumber / notation;
            };

            return numberRepresentation;
        }
    }
}
