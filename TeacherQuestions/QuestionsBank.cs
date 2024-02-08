using System.Collections.Generic;

namespace TeacherQuestions
{
    public static class QuestionsBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WHQuestion
                {
                    Title = "what is the question?",
                    Mark = 3
                },
                new WHQuestion
                {
                    Title = "Why does the question to answer ?",
                    Mark = 3
                },
                new MultipleChoicesQuestion
                {
                    Title = "choice the correct answer.",
                    Mark = 2,
                    Choices = new List<string>()
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
                new TrueFalseQuestion
                {
                    Title = "put the mark of answer true or false ?",
                    Mark = 1
                },


            };
        }



    }

}
