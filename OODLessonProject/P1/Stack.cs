using System;

namespace OODLessonProject.P1
{
    class Stack
    {
        private int max;
        private int top;
        private char[] data;
        public Stack(int n)
        {
            if (n <= 0)
                throw new Exception("Stack capacity must be at least one");
            this.max = n;
            this.data = new char[this.max];
            this.top = -1;
        }
        public bool IsEmpty
        {
            get
            {
                if (this.top == -1)
                    return true;
                return false;
            }
        }
        public bool IsFull
        {
            get
            {
                if (this.top == this.max - 1)
                    return true;
                return false;
            }
        }
        public int Capacity
        {
            get
            {
                return this.max;
            }
        }
        public int Size
        {
            get
            {
                return this.top + 1;
            }
        }
        public void Push(char ch)
        {
            if (this.IsFull)
                throw new Exception("The stack is full");
            this.top++;
            this.data[this.top] = ch;
        }
        public char Pop()
        {
            if (this.IsEmpty)
                throw new Exception("The stack is empty");
            char ch = this.data[this.top];
            this.top--;
            return ch;
        }
        public char Read()
        {
            if (this.IsEmpty)
                throw new Exception("The stack is empty");
            return this.data[this.top];
        }
        public void Clear()
        {
            this.top = -1;
        }
        public string Print()
        {
            string str = "";
            while (this.IsEmpty == false)
                str += this.Pop().ToString();
            return str;
        }
    }
}
