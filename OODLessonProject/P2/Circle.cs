using System;

namespace OODLessonProject.P2
{
    class Circle
    {
        private double radius;

        public Circle()
        {
            radius = 0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public Circle(Circle other)
        {
            radius = other.radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
        public double Area()
        {
            return Math.PI * radius * radius;
        }
    }
}
