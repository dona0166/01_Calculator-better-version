using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ADDITION");
            Console.WriteLine("First factor:");
            string stringA = Console.ReadLine();
            int a = int.Parse(stringA);
            Console.WriteLine("Second factor:");
            string stringB = Console.ReadLine();
            int b = int.Parse(stringB);
            Console.WriteLine("The result is " + Calculator.Add(a,b));
            Console.WriteLine(">>>Press Enter<<<");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("SUBTRACTION");
            Console.WriteLine("First factor:");
            string stringC = Console.ReadLine();
            int c = int.Parse(stringC);
            Console.WriteLine("Second factor:");
            string stringD = Console.ReadLine();
            int d = int.Parse(stringD);
            Console.WriteLine("The result is " + Calculator.Subtract(a, b));
            Console.WriteLine(">>>Press Enter<<<");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("SUM MORE NUMBERS");
            Console.WriteLine("How many numbers would you like to sum?");
            string sumnumbers = Console.ReadLine();
            int count = 1;
            int[] anarray = new int[int.Parse(sumnumbers)];
            for (int i = 0; i < anarray.Length; i++){
                Console.WriteLine("Factor " + count + ":");
                count++;
                anarray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Result:" + Calculator.Sum(anarray));
            Console.WriteLine(">>>Press enter<<<");
            Console.ReadKey();

            
            Console.WriteLine("");
            Console.WriteLine("MULTIPLY");
            Console.WriteLine("How many numbers would you like to multiply?");
            string multnumbers = Console.ReadLine();
            int count2 = 1;
            int[] anarray2 = new int[int.Parse(multnumbers)];
            for (int i = 0; i < anarray2.Length; i++)
            {
                Console.WriteLine("Factor " + count2 + ":");
                count2++;
                anarray2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Result:" + Calculator.Multiply(anarray2));
            Console.WriteLine(">>>Press enter<<<");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("POWER");
            Console.WriteLine("Number:");
            string stringnumber = Console.ReadLine();
            int yournumber = int.Parse(stringnumber);
            Console.WriteLine("Exponent:");
            string exponent = Console.ReadLine();
            int yourexponent = int.Parse(exponent);
            Console.WriteLine("The result is " + Calculator.Power(yournumber,yourexponent));
            Console.WriteLine(">>>Press Enter<<<");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("FACTORIAL");
            Console.WriteLine("Factorial of:");
            string stringfactorial = Console.ReadLine();
            int yourfactorial = int.Parse(stringfactorial);
            Console.WriteLine("The result is " + Calculator.Factorial(yourfactorial));
            Console.WriteLine(">>>Press Enter<<<");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Thanks for you cooperation, next time you should use a true calculator.");
            Console.WriteLine(">>>>>Press Enter to cause a nuclear explosion<<<<<");
            Console.ReadKey();







        }
    }
}
