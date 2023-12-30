namespace OODLessonProject.P7
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            StudentID = id;
            Name = name;
        }
    }
}
