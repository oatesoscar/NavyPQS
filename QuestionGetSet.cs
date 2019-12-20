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
       
        public void GetAndStoreQuestionsFromTextFile(string txtFilePath)
        {
            var questionsText = TextReadWrite.readTextFile(txtFilePath);
            TextReadWrite.CreateQuestionObjects(questionsText);
        }

        public void StoreQuestionObjectsToJsonFile(string jsonFilePath)
        {
            JsonReadWrite.writeQuestionToJsonFile(TextReadWrite.questionObjectList, jsonFilePath);
        }

        public void GetAndStoreQuestionsFromJsonFile(string jsonFilePath)
        {
            JsonReadWrite.readQuestionsFromJsonFile(jsonFilePath);
        }

    }
}
