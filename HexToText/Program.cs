using System.Text;

namespace HexToText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> hexList = new List<string> { "A4", "E6", "16", "76", "56", "C7", "32", "05", "54", "B2", "04", "C7",
                "46", "42", "E2", "E2", "E2", "E2", "E2", "E2", "E3", "9C", "15", "AF", "43" };

            string textString = string.Empty;

            for (int i = 0; i < 20; i++) 
            {
                textString += (char)Convert.ToInt32(hexList[i], 16);
            }

            DateTime date = new DateTime(1000, 1, 1);

            for(int i = 0; i < 10; i++)
            {
                date = date.AddDays(Convert.ToInt32(hexList[i], 16));
            }

            Console.WriteLine("BitA = " + (Convert.ToInt32(hexList[0].Substring(0 , 1), 16) > 9));
            Console.WriteLine("BitB = " + (Convert.ToInt32(hexList[1].Substring(0, 1), 16) > 9));
            Console.WriteLine("BitC = " + (Convert.ToInt32(hexList[2].Substring(0, 1), 16) > 9));
            Console.WriteLine("BitD = " + (Convert.ToInt32(hexList[3].Substring(0, 1), 16) > 9));
            Console.WriteLine("TextA = " + textString);
            Console.WriteLine("ShortA = " + Convert.ToInt16(hexList[0], 16));
            Console.WriteLine("DateTimeA = " + date.ToString());
        }
    }
}