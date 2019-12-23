using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;



namespace NavyPQS
{
    class QuestionGetSet
    {
        JsonReadWrite JsonReadWrite = new JsonReadWrite();
        TextReadWrite TextReadWrite = new TextReadWrite();      
        public void GetAndStoreTextQuestions(string txtFilePath)
        {
            var questionsText = TextReadWrite.ReadTextFile(txtFilePath);
            TextReadWrite.CreateQuestionObjects(questionsText);
        }
        public void StoreQuestionObjectsToJson(string jsonFilePath)
        {
            JsonReadWrite.writeQuestions(TextReadWrite.questionObjectList, jsonFilePath);
        }
        public void GetAndStoreJsonQuestions(string jsonFilePath)
        {
            JsonReadWrite.readQuestions();
        }
    }
}
