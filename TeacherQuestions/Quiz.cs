using System;
using System.Collections.Generic;

namespace TeacherQuestions
{
    public class Quiz
    {
        public List<Teach> _teachs { get; }
        public List<Question> _questions { get; }
        public Quiz(List<Teach> teachs, List<Question> questions)
        {
            _teachs = teachs;
            _questions = questions;
        }


        public void Print() {
            foreach (var item in _teachs)
            {
                item.Print();
                Console.WriteLine("\n");
            }
            foreach (var item in _questions)
            {
                item.Print();
                Console.WriteLine("\n");
            }
        }
    }

}
