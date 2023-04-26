using System.Text;

namespace HexToText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> hexList = new List<string> { "A4", "E6", "16", "76", "56", "C7", "32", "05", "54", "B2", "04", "C7",
                "46", "42", "E2", "E2", "E2", "E2", "E2", "E2", "E3", "9C", "15", "AF", "43" };

            foreach(string hex in hexList)
            {
                int decimalValue = Convert.ToInt32(hex, 16);

                Console.WriteLine($"The Decimal Value is {decimalValue} and the Char Value is {(char)decimalValue}");
            }
            

        }
    }
}