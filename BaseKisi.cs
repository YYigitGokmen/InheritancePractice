using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public abstract class BaseKisi
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }


        public BaseKisi(string name,string surname)
        {
        Name = name;
        Surname = surname;

        }

        public void Promter()
        {
            Console.WriteLine($"Adınız {Name}, Soyadınız {Surname}");
        }

    }


    public class Student : BaseKisi
    {
        public string? StudentId { get; set; }

        public Student(string name, string surname, string studentId)
            : base(name, surname)
        {
            StudentId = studentId;
        }


        public void StudentMethod()
        {
            Console.WriteLine($"Öğrenci numaranız: {StudentId}");

            Promter();
            //Dikkat ->  Bir metot içerisinde başka bir metodu çağırabileceğinizi unutmayınız.

        }
    }


        public class Teacher : BaseKisi
        {
            //Ogretmen için ilave propertyler -> Maaş Bilgisi
            public int TeacherSalary { get; set; }

        
            public Teacher(string name, string surname, int teacherSalary)
                : base(name, surname)
            {
                TeacherSalary = teacherSalary;
            }
        
            public void TeacherMethod() 
        {
            Console.WriteLine($"Öğretmen Maaşınız: {TeacherSalary}");

            Promter();

        

        }



    }


    }



    
