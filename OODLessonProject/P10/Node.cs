namespace OODLessonProject.P10
{
    public class Node
    {
        private static int idCounter = 100;

        private int data;
        private int id;

        public Node(int data)
        {
            this.data = data;
            id = idCounter++;
        }
    }
}
