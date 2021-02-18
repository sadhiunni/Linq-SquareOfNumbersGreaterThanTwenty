using System;
using System.Linq;

/*Finding the number whose sqaure is greater than twenty.
 */
namespace Linq_SquareOfNumbersGreaterThanTwenty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers in the array - Complete List");
            Console.WriteLine("-----*****-----");
            int[] arrayNumbers = new int[] {1,2,3,4,5,7,8,9,10};
            foreach (var number in arrayNumbers)
            {
                Console.WriteLine(number);
            }
            var squareNo = from int number in arrayNumbers
                           let sqrNum = number * number
                           where sqrNum > 20
                           select new { number, sqrNum };
            Console.WriteLine("-----*****-----");
           
            Console.WriteLine("---------------");
            
            Console.WriteLine("-----*****-----");
            Console.WriteLine("Numbers in the array whose square is greater than 20");
            foreach(var number in squareNo)
                {
                Console.WriteLine(number);
                }
            Console.WriteLine("-----*****-----");

        }
    }
}
