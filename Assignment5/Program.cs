using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number :  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = a/b;
                Console.WriteLine("Division of a and b is :  " + result);

            }
            catch(DivideByZeroException ex) {
                Console.WriteLine("Divide by Zero is not Allowed."+ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block Executed.");
            }
        }
    }
}
