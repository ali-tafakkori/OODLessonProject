namespace OODLessonProject.P4
{
    class Point
    {
        private int x;
        private int y;


        public Point(Point other)
        {
            this.x = other.x;
            this.y = other.y;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }
    }
}
