

using InheritancePractice;

public class Program
{

    public static void Main(string[] args)
    {


        Student student = new Student("Yiğit","GÖKMEN","123456789");

        student.StudentMethod();

        Console.WriteLine("---------------------------");


        Teacher teacher = new Teacher("HASAN","ALİ",100);

        teacher.TeacherMethod();


    }
}




