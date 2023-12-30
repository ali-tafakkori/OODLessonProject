namespace OODLessonProject.P7
{
    public class LinkedList
    {
        private Node first;
        private Node last;

        public void Add(Student data)
        {
            Node newNode = new Node(data);
            if (first == null)
            {
                first = newNode;
                last = first;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
            last.Next = first;
        }
    }
}
