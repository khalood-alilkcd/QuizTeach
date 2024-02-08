using System;

namespace TeacherQuestions
{
    public class Student : Teach
    {
        public override void Print()
        {
            Console.WriteLine($" name of a student is {Name} ");
            foreach (var item in Materials)
            {
                Console.WriteLine($"and his study material {item}");
            }
        }
    }

}
