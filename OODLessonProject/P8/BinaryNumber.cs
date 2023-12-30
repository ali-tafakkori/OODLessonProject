using System;

namespace OODLessonProject.P8
{
    class BinaryNumber
    {
        private string binaryValue = "";

        public BinaryNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0' || s[i] == '1')
                {
                    binaryValue = s[i].ToString() + binaryValue;
                }
                else
                    throw new Exception("Invalid data");
            }

        }

        public BinaryNumber(BinaryNumber binaryNumber) {
            this.binaryValue = binaryNumber.binaryValue;
        }

        public string Value
        {
            get
            {
                return binaryValue;
            }
        }
        public int Length
        {
            get
            {
                return binaryValue.Length;
            }
        }

        public char this[int i]
        {
            get
            {
                if (i < 0 || i >= this.Length)
                    throw new Exception("Index out of range");
                return binaryValue[i];
            }
        }

        public BinaryNumber Not()
        {
            string result = "";
            foreach (char bit in binaryValue)
            {
                result += (bit == '0') ? '1' : '0';
            }
            return new BinaryNumber(result);
        }

        public BinaryNumber Or(BinaryNumber otherBinary)
        {
            if (otherBinary.Length != binaryValue.Length)
            {
                throw new Exception("Both binary numbers must have the same length for the OR operation.");
            }

            string result = "";
            for (int i = 0; i < binaryValue.Length; i++)
            {
                result += (binaryValue[i] == '1' || otherBinary[i] == '1') ? '1' : '0';
            }
            return new BinaryNumber(result);
        }

        public BinaryNumber And(BinaryNumber otherBinary)
        {
            if (otherBinary.Length != binaryValue.Length)
            {
                throw new Exception("Both binary numbers must have the same length for the AND operation.");
            }

            string result = "";
            for (int i = 0; i < binaryValue.Length; i++)
            {
                result += (binaryValue[i] == '1' && otherBinary[i] == '1') ? '1' : '0';
            }
            return new BinaryNumber(result);
        }

        public BinaryNumber Xor(BinaryNumber otherBinary)
        {
            if (otherBinary.Length != binaryValue.Length)
            {
                throw new Exception("Both binary numbers must have the same length for the XOR operation.");
            }

            string result = "";
            for (int i = 0; i < binaryValue.Length; i++)
            {
                result += (binaryValue[i] != otherBinary[i]) ? '1' : '0';
            }
            return new BinaryNumber(result);
        }

        public BinaryNumber TwosComplement()
        {
            BinaryNumber onesComplement = this.Not();
            string twosComplement = "";
            bool carry = true;

            for (int i = onesComplement.Length - 1; i >= 0; i--)
            {
                if (carry)
                {
                    if (onesComplement[i] == '1')
                    {
                        twosComplement = '0' + twosComplement;
                    }
                    else
                    {
                        twosComplement = '1' + twosComplement;
                        carry = false;
                    }
                }
                else
                {
                    twosComplement = onesComplement[i] + twosComplement;
                }
            }

            return new BinaryNumber(twosComplement);
        }
    }
}
