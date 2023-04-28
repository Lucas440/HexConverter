using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToText
{
    public class FileHandler
    {
        private string _filePath;

        public FileHandler(string filepath)
        {
            _filePath = filepath;
        }

        public Dictionary<int , List<string>> ReadFile()
        {
            List<string> hexStringList = new List<string>();

            int indexCounter = 0;

            Dictionary<int, List<string>> hexDictionary = new Dictionary<int, List<string>>();

            using(StreamReader reader = new StreamReader(_filePath))
            {
                do
                {
                    string line = reader.ReadLine();

                    List<string> hexSplit = line.Split(' ').ToList();

                    hexDictionary.Add(indexCounter++, hexSplit);
                } while (reader.Peek() != -1);
            }

            return hexDictionary;
        }
    }
}
