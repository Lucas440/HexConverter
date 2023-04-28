using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToHex
{
    public class HexGUI_Logic
    {
        private string _textBoxText;

        private bool _bitA, _bitB, _bitC, _bitD;

        public bool BitA { get => _bitA; set => _bitA = value; }
        public bool BitB { get => _bitB; set => _bitB = value; }
        public bool BitC { get => _bitC; set => _bitC = value; }
        public bool BitD { get => _bitD; set => _bitD = value; }

        private short _shortValue;

        private int _timeToInputDate;

        public string OnTextChange(string text) 
        {
            if(text.Length < 20) _textBoxText = text;
            return _textBoxText;
        }

        public void OnShortChange(string value)
        {
            if (int.TryParse(value, out int result)) 
            {
                if (result < short.MaxValue && result > short.MinValue) 
                {
                    _shortValue = (short)result;
                }
            }
        }

        public void OnDateChange(DateTime input)
        {
            DateTime baseTime = new DateTime(1000 , 1, 1);

            _timeToInputDate = (int)((input - baseTime).TotalDays);
        }

        public string ConvertToHex()
        {
            string outputString = string.Empty;
            outputString += (BitConverter.ToString(Encoding.ASCII.GetBytes(_bitA.ToString())));
            outputString+= (BitConverter.ToString(Encoding.ASCII.GetBytes(_bitB.ToString())));
            outputString += (BitConverter.ToString(Encoding.ASCII.GetBytes(_bitC.ToString())));
            outputString += (BitConverter.ToString(Encoding.ASCII.GetBytes(_bitD.ToString())));

            outputString += (BitConverter.ToString(Encoding.ASCII.GetBytes(_shortValue.ToString())));

            outputString+= (BitConverter.ToString(Encoding.ASCII.GetBytes(_timeToInputDate.ToString())));

            outputString+= (BitConverter.ToString(Encoding.ASCII.GetBytes(_textBoxText)));

            return outputString;
        }
    }
}
