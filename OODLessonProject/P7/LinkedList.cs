namespace OODLessonProject.P7
{
    public class LinkedList
    {
        private Node first;
        private Node last;

        public void Add(Student data)
        {
            Node newNode = new Node(data);
            if (last == null)
            {
                first = newNode;
                last = newNode;
            }
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }

        public string Print()
        {
            string s = "";
            Node current = first;
            while (current != null)
            {
                s += current.Data.StudentID + " : " + current.Data.Name + ", ";
                current = current.Next;
            }
            return s;
        }
    }
}
