using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherQuestions
{
    public abstract class Teach
    {
        public string Name { get; set; }
        public List<Material> Materials  { get; set; }
        public abstract void Print();
    }
}
