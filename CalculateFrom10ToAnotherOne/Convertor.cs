using System.Collections.Generic;

namespace CalculateFrom10ToAnotherOne
{
    public class Convertor
    {
        private static readonly Dictionary<string, string> convertorRepresentation = new Dictionary<string, string>()
        {
            { "10", "A" },
            { "11", "B" },
            { "12", "C" },
            { "13", "D" },
            { "14", "E" },
            { "15", "F" },
            { "16", "G" },
            { "17", "H" },
            { "18", "I" },
            { "19", "J" }
        };

        public static string ConvertNumberToAnotherNotation(int decimalNumber, int notation)
        {
            List<string> numberRepresentation = new List<string>();
            string number = "";
          
            while (decimalNumber >= 1)
            {          
                int mod = decimalNumber % notation;
                numberRepresentation.Add(mod.ToString());

                decimalNumber /= notation;
            };

            for (int i = numberRepresentation.Count - 1; i >= 0; i--)
            {
                foreach (var key in convertorRepresentation.Keys)
                {
                   if (numberRepresentation[i] == key)
                    {
                        numberRepresentation[i] = convertorRepresentation[key];
                    }
                }
          
                number += numberRepresentation[i];
            }

            return number;
        }
    }
}
