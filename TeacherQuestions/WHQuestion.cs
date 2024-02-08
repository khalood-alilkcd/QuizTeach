using System;

namespace TeacherQuestions
{
    public class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
        }
    }


}
