using System;

namespace OODLessonProject.P6
{
    class Vector
    {
        public Vector(int size)
        {
            if (size <= 0)
                throw new Exception("Vector size must be at least one");
            this.size = size;
            this.data = new int[this.size];
        }
        public Vector(Vector v)
        {
            this.size = v.Size;
            this.data = new int[this.size];
            for (int i = 0; i < this.size; i++)
                this.data[i] = v.data[i];
        }
        private int size;
        private int[] data;
        public int Size
        {
            get { return this.size; }
        }
        public int this[int i]
        {
            get
            {
                if (i < 0 || i >= this.size)
                    throw new Exception("Index out of range");
                return this.data[i];
            }
            set
            {
                if (i < 0 || i >= this.size)
                    throw new Exception("Index out of range");
                this.data[i] = value;
            }
        }

        public string Print()
        {
            string res = "";
            foreach (int d in data)
            {
                res += (d + " ");
            }
            return res;
        }
        public void Sort()
        {
            Array.Sort(data);
        }
        public int Search(int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
        public int Maximum()
        {
            int max = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
            }
            return max;
        }
        public int Minimum()
        {
            int min = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
            }
            return min;
        }
        public double Average()
        {
            int average = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                average += data[i];
            }
            return average / data.Length;
        }
    }
}
