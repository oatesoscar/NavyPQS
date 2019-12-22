using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace NavyPQS
{
    class QuestionSkeleton
    {
        public string classID { get; set; }
        public string questionNumber { get; set; }
        public string question { get; set; }
        public string correctAnswer { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }

        public string GetSummary()
        {
            string summary = $"{classID} , {questionNumber} , {question} ,";
            return summary;
        }
    }

}
