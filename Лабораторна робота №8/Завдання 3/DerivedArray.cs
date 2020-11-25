using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_3
{
    class DerivedArray : IntArray
    {
        private char[] alphaviteEng;

        public int[] PropertInts
        {
            get { return new int[2] { ArrayInts, alphaviteEng.Length }; }
        }

        public DerivedArray()
        {
            alphaviteEng = new char[26];
        }
        public char this[char index]
        {
            get
            {
                return alphaviteEng[Convert.ToChar(index.ToString().ToLower()) - 'a'];
            }
            set
            {
                alphaviteEng[Convert.ToChar(index.ToString().ToLower()) - 'a'] = value;
            }
        }
    }
}
