using System;

namespace TeacherQuestions
{
    public class TrueFalseQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"1. is true");
            Console.WriteLine($"2. is false");
        }
    }

}
