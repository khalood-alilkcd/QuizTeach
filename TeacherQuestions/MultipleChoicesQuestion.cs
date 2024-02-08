using System;
using System.Collections.Generic;

namespace TeacherQuestions
{
    public class MultipleChoicesQuestion : Question
    {
        public List<string> Choices = new List<string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var item in Choices)
            {
                Console.WriteLine($"{item}");
            }
        }
    }


}
