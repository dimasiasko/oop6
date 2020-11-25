using System;
using System.Collections.Generic;
using System.Text;

namespace Завдання_3
{
    class IntArray
    {
        private int[] arrayInts;

        public IntArray()
        {
            arrayInts = new int[10];
        }
        public int ArrayInts
        {
            get { return arrayInts.Length; }
        }
        public int this[int index]
        {
            get { return arrayInts[index]; }
            set { arrayInts[index] = value; }
        }
    }
}
