using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherQuestions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quizTeach = new Quiz(TeachsBank.GenerateTeach(), QuestionsBank.Generate());
            quizTeach.Print();

            Console.ReadLine();
        }
    }
}
