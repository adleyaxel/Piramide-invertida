using System;
namespace PatternDemo
{
    public class NewBaseType
    {
        public static void Main()
        {
            Console.Write("Enter Number of Rows :");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = rows; i >= 1; i--)
            {
                //j<=i  //let rows = 5
                /* first row (0 to 5) = 5 numbers (1,2,3,4,5)
                 * second row (0 to 4) = 4 numbers (1,2,3,4)
                 * third row (0 to 3) = 3 numbers (1,2,3)
                 * and so on
               */
                //calculate stars for each row one by one
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}