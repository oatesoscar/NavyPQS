using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;


namespace QuestionCreator
{
    class JsonReadWrite
    {
        private List<QuestionSkeleton> JsonObjectList = new List<QuestionSkeleton>();
  
        public void writeQuestionToJsonFile(List<QuestionSkeleton> questionObjectList, string jsonFilePath)
        {
            string jsonResult = JsonConvert.SerializeObject(questionObjectList, Formatting.Indented);
            File.AppendAllText(jsonFilePath, jsonResult);
            Console.WriteLine($"{questionObjectList.Count} questions have been added to the Json file");
        }

        public List<QuestionSkeleton> readQuestionsFromJsonFile(string jsonFilePath)
        {
            string jsonFile = System.IO.File.ReadAllText(jsonFilePath);
            JsonObjectList = JsonConvert.DeserializeObject<List<QuestionSkeleton>>(jsonFile);
            return JsonObjectList;
        }

        public void printJsonQuestionsSummary()
        {
            foreach (var item in JsonObjectList)
            {
                Console.WriteLine(item.GetSummary());
            }
        }
    }
}
