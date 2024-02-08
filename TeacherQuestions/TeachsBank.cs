using System.Collections.Generic;

namespace TeacherQuestions
{
    public static class TeachsBank
    {
        public static List<Teach> GenerateTeach()
        {
            return new List<Teach>
            {
                new Teacher
                {
                    Name = "Mohamed",
                    Materials = new List<Material>
                    {
                        new Material
                        {
                            Name = "Arabic"
                        },
                        new Material
                        {
                            Name = "English"
                        }
                    }
                },
                new Student
                {
                    Name = "Abdo hassen",
                    Materials = new List<Material>
                    {
                        new Material
                        {
                            Name = "Arabic",
                            Degree = 50
                        },
                        new Material
                        {
                            Name = "English",
                            Degree = 70
                        }
                    }

                },
                new Student
                {
                    Name = "Mohamed hassen",
                    Materials = new List<Material>
                    {
                        new Material
                        {
                            Name = "Arabic",
                            Degree  = 60
                        }
                    }
                }

            };
        }
    }

}
