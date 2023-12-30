namespace OODLessonProject.P10
{
    public class Node
    {
        private static int idCounter = 100;

        int data;
        public int id;

        public Node(int data)
        {
            this.data = data;
            id = idCounter++;
        }
    }
}
