using System.Collections.Generic;

namespace OODLessonProject.P5
{
    class Polygon
    {
        private List<Point> points;

        public Polygon(List<Point> points)
        {
            this.points = new List<Point>();

            foreach (Point p in points)
            {
                this.points.Add(p);
            }
        }

        public Point this[int i]
        {
            get
            {
                return points[i];
            }
            set
            {
                points[i] = value;
            }
        }
    }
}
