using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HexToText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileHandler fileHandler = new FileHandler("..\\..\\..\\HexCodes.txt");

            Dictionary<int, List<string>> hexDictionary = fileHandler.ReadFile();

            foreach(List<string> hexList in hexDictionary.Values) Output(hexList);
        }

        public static void Output(List<string> hexList)
        {

            hexList.ForEach(x => Console.Write(x + " "));

            Console.WriteLine();

            Console.WriteLine("BitA = " + (Convert.ToInt32(hexList[0].Substring(0, 1), 16) > 9));
            Console.WriteLine("BitB = " + (Convert.ToInt32(hexList[1].Substring(0, 1), 16) > 9));
            Console.WriteLine("BitC = " + (Convert.ToInt32(hexList[2].Substring(0, 1), 16) > 9));
            Console.WriteLine("BitD = " + (Convert.ToInt32(hexList[3].Substring(0, 1), 16) > 9));
            Console.WriteLine("TextA = " + ConvertHexToString(hexList));
            Console.WriteLine("ShortA = " + Convert.ToInt16(hexList[0], 16));
            Console.WriteLine("DateTimeA = " + GetDateTime(hexList).ToString());

            Console.WriteLine();
        }

        public static string ConvertHexToString(List<string> hexList)
        {
            string textString = string.Empty;

            for (int i = 0; i < 20; i++)
            {
                textString += (char)Convert.ToInt32(hexList[i], 16);
            }

            return textString;
        }

        public static DateTime GetDateTime(List<string> hexList) 
        {
            DateTime date = new DateTime(1000, 1, 1);

            for (int i = 0; i < 10; i++)
            {
                date = date.AddDays(Convert.ToInt32(hexList[i], 16));
            }

            return date;
        }
    }
}