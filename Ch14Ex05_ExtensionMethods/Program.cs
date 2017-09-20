using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionLib;//import namespace of the extension method class.

/*
 * To create and use an extension methods you must do the following:
 * 1. Create a nongeneric static class.
 * 2. Add extension methods as static methods to the static class, using extension method syntax:
 *      a. The method must be static.
 *      b. The method must include the instance parameter, a parameter representing the instance of the type being extended.
 *      c. The instance parameter must be the first parameter defined for the method.
 *      d. The instance parameter must have no modifiers other than the required this keyword.
 *      template: public static <<ReturnType>> <<ExtensionMethodName>>(this <<TypeToExtend>> <<Instance>>) { ... }
 * 3. Import the namespace containing the extension method class into the code where you want to use it (with a using statement.)
 * 4. Call your extension methods through instances of the extended type, just like any other method. 
 */

namespace Ch14Ex05_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to convert:");
            string sourceString = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("String with title casing:");
            Console.WriteLine($"{sourceString.GetWords(capitalizeWords: true).AsSentence()}");
            Console.WriteLine();
            Console.WriteLine("String backwards:");
            Console.WriteLine($"{sourceString.GetWords(reverseOrder: true, reverseWords: true).AsSentence()}");
            Console.WriteLine();
            Console.WriteLine("String length backwards:");
            Console.WriteLine($"{sourceString.Length.ToStringReversed()}");
            Console.ReadKey();
        }
    }
}
