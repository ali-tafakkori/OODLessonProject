using System;

namespace OODLessonProject.P5
{
    class Polygon
    {
        private Point[] points;

        public Polygon(Point[] points)
        {
            this.points = new Point[points.Length];

            for (int i = 0; i < points.Length; i++)
            {
                this.points[i] = points[i];
            }
        }

        public Point this[int i]
        {
            get
            {
                if (i < 0 || i >= points.Length)
                    throw new Exception("Index out of range");
                return points[i];
            }
            set
            {
                if (i < 0 || i >= points.Length)
                    throw new Exception("Index out of range");
                points[i] = value;
            }
        }
    }
}
