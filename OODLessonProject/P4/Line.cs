using System;

namespace OODLessonProject.P4
{
    class Line
    {
        private Point p1, p2;

        public Line()
        {
        }
        public Line(Line other)
        {
            p1 = new Point(other.p1);
            p2 = new Point(other.p2);
        }
        public Line(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public double Length
        {
            get
            {
                return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            }
        }
    }
}
