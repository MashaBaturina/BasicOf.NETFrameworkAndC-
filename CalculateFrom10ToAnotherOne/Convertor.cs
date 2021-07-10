using System.Collections.Generic;

namespace CalculateFrom10ToAnotherOne
{
    public class Convertor
    {       
        public static string ConvertNumberToAnotherNotation(int decimalNumber, int notation)
        {
            List<string> numberRepresentation = new List<string>();
            string number = "";
          
            while (decimalNumber >= 1)
            {          
                int mod = decimalNumber % notation;
                numberRepresentation.Add(mod.ToString());

                decimalNumber = decimalNumber / notation;
            };

            for (int i = numberRepresentation.Count - 1; i >= 0; i--)
            {
                switch (numberRepresentation[i])
                {
                    case "10":
                        numberRepresentation[i] = "A";
                        break;
                    case "11":
                        numberRepresentation[i] = "B";
                        break;
                    case "12":
                        numberRepresentation[i] = "C";
                        break;
                    case "13":
                        numberRepresentation[i] = "D";
                        break;
                    case "14":
                        numberRepresentation[i] = "E";
                        break;
                    case "15":
                        numberRepresentation[i] = "F";
                        break;
                    case "16":
                        numberRepresentation[i] = "G";
                        break;
                    case "17":
                        numberRepresentation[i] = "H";
                        break;
                    case "18":
                        numberRepresentation[i] = "I";
                        break;
                    case "19":
                        numberRepresentation[i] = "J";
                        break;
                    default:
                        numberRepresentation[i] = numberRepresentation[i];
                        break;
                }

                number += numberRepresentation[i];
            }

            return number;
        }
    }
}
