using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string ifade = Console.ReadLine();

            Console.WriteLine(convertBinarytoDecimal(ifade));

        }

        public static int convertBinarytoDecimal(string str)
        {
            str = str.Trim();
            int n = str.Length;
            int number = Convert.ToInt32(str);
            int temp;
            int[] binaryNumber = new int[100];

            for (int i = 0; i < n; i++)
            {

                temp = number % 10;
                number = number / 10;

                if (temp != 0 && temp != 1)
                {
                    Console.WriteLine("Error");
                    break;
                }

                binaryNumber[i] = temp;
            }
            int sum = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                sum = sum + binaryNumber[i] * (int)Math.Pow(2, i);
            }
            return sum;
        }
    }
}
