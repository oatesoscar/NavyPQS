using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace NavyPQS
{
    class JsonReadWrite
    {
        private List<QuestionSkeleton> JsonObjectList = new List<QuestionSkeleton>();
        private readonly FileIO fileIO = new FileIO();
        // Writes Questions to Questions.json
        public void writeQuestions(List<QuestionSkeleton> questionObjectList,string jsonFilePath)
        {
            string jsonResult = JsonConvert.SerializeObject(questionObjectList, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonResult);
        }
        // Reads Questions from Questions.json
        // Returns a list of questions.
        public List<QuestionSkeleton> readQuestions()
        {
            string jsonFile = File.ReadAllText(fileIO.JsonQuestions);
            JsonObjectList = JsonConvert.DeserializeObject<List<QuestionSkeleton>>(jsonFile);
            return JsonObjectList;
        }
        // Reads Users from UserFile.json
        public List<User> ReadUsers()
        {
            string jsonUserFileText = File.ReadAllText(fileIO.UserFileJson);
            if (jsonUserFileText == null || jsonUserFileText == "")
            {
                jsonUserFileText = File.ReadAllText(fileIO.DefaultUserJson);
            }
            var UserList = JsonConvert.DeserializeObject<List<User>>(jsonUserFileText);
            return UserList;           
        }
        // Adds a new user to UserFile.json
        public void AddUser(User user)
        {
            List<User> jsonList = ReadUsers();
            jsonList.Add(user); 
            string jsonResult = JsonConvert.SerializeObject(jsonList, Formatting.Indented);
            File.WriteAllText(fileIO.UserFileJson, jsonResult);
        }
    }
}
