using OOPs;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Walk();
            Teacher teacher = new Teacher();
            teacher.Walk();


            student.Talk();
        }

    }
}