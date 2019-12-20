using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace NavyPQS
{
    class JsonReadWrite
    {
        private List<QuestionSkeleton> JsonObjectList = new List<QuestionSkeleton>();
  
        public void writeQuestionToJsonFile(List<QuestionSkeleton> questionObjectList, string jsonFilePath)
        {
            string jsonResult = JsonConvert.SerializeObject(questionObjectList, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonResult);
        }

        public List<QuestionSkeleton> readQuestionsFromJsonFile(string jsonFilePath)
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            JsonObjectList = JsonConvert.DeserializeObject<List<QuestionSkeleton>>(jsonFile);
            return JsonObjectList;
        }
    }
}
