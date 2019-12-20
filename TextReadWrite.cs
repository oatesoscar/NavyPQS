using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuestionCreator
{
    class TextReadWrite
    {
        public List<QuestionSkeleton> questionObjectList = new List<QuestionSkeleton>();
               
        protected private int index = 0;

        public string[] readTextFile(string txtFilePath)
        {
            string text = System.IO.File.ReadAllText(txtFilePath);
            text = text.Replace("\r\n", string.Empty);
            string[] textSplit = text.Split('*');
            textSplit = textSplit.Where(c => c != null).ToArray();
            var questions = textSplit.Where(c => c != "").ToArray();
            return questions;
        }

        public void CreateQuestionObjects(string[] questionsText)
        {
            try
            {
                foreach (var item in questionsText)
                {
                    QuestionSkeleton Question = new QuestionSkeleton();

                    Question.classID = questionsText[index];
                    index++;
                    Question.questionNumber = questionsText[index];
                    index++;
                    Question.question = questionsText[index];
                    index++;
                    Question.answer1 = questionsText[index];
                    index++;
                    Question.answer2 = questionsText[index];
                    index++;
                    Question.answer3 = questionsText[index];
                    index++;
                    questionObjectList.Add(Question);
                    Console.WriteLine($"Question number {Question.questionNumber} under Class ID: {Question.classID} has been stored as an object");
                }
                Console.WriteLine($"number of questions stored as objects = {questionObjectList.Count}");
            }
            catch (Exception)
            {
                Console.WriteLine("Action Completed");
            }
        }
    }
}
