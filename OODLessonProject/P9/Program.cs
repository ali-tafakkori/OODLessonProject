using System;

namespace OODLessonProject.P9
{
    class Program
    {
        private static int count = 0;

        private string path;

        public Program(string path)
        {
            if (count >= 1) 
                throw new Exception("Can't create twice");
            count++;

            this.path = path;
        }
    }
}
