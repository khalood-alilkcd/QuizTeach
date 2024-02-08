using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherQuestions
{
    public class Teacher : Teach
    {
        public override void Print()
        {
            Console.WriteLine($" name of a teacher is {Name} ");
            foreach (var item in Materials)
            {
                Console.WriteLine($"and his teach material { item}");
            }
        }
    }


}
