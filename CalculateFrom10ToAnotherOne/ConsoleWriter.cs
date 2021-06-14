using System;
using System.Collections.Generic;

namespace CalculateFrom10ToAnotherOne
{
    public class ConsoleWriter
    {
        public static void PrintNumberRepresentation(List<int> numberRepresentation)
        {
            for (int i = numberRepresentation.Count - 1; i >= 0; i--)
            {
                switch (numberRepresentation[i])
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    case 16:
                        Console.Write("G");
                        break;
                    case 17:
                        Console.Write("H");
                        break;
                    case 18:
                        Console.Write("I");
                        break;
                    case 19:
                        Console.Write("J");
                        break;
                    default:
                        Console.Write(numberRepresentation[i]);
                        break;
                }
            }
        }
    }
}
