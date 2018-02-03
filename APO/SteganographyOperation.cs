using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APO
{
    class SteganographyOperation
    {

        protected byte[] toBits(byte pixel)
        {
            BitArray bits = new BitArray(new byte[] { pixel });
            bool[] bools = new bool[bits.Count];
            bits.CopyTo(bools, 0);
            byte[] bitsArray = bools.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(bitsArray);

            return bitsArray;
        }

        protected byte toByte(byte[] bits)
        {
            String bitString = ""
                + bits[0]
                + bits[1]
                + bits[2]
                + bits[3]
                + bits[4]
                + bits[5]
                + bits[6]
                + bits[7];

            return Convert.ToByte(bitString, 2);
        }
    }
}
