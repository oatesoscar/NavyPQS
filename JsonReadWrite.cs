using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace NavyPQS
{
    class JsonReadWrite
    {
        private List<QuestionSkeleton> JsonObjectList = new List<QuestionSkeleton>();
        public string UserFileJson { get; set; } = @"C:\Users\HomicidalMAdMan\Documents\GitHub\NavyPQS\Users.json";
        public string DefaultUserJson { get; set; } = @"C:\Users\HomicidalMAdMan\Documents\GitHub\NavyPQS\Default.json";

        // Writes Questions to Questions.json
        public void writeQuestions(List<QuestionSkeleton> questionObjectList, string jsonFilePath)
        {
            string jsonResult = JsonConvert.SerializeObject(questionObjectList, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonResult);
        }

        // Reads Questions from Questions.json
        public List<QuestionSkeleton> readQuestions(string jsonFilePath)
        {
            string jsonFile = File.ReadAllText(jsonFilePath);
            JsonObjectList = JsonConvert.DeserializeObject<List<QuestionSkeleton>>(jsonFile);
            return JsonObjectList;
        }

        // Reads Users from UserFile.json
        public List<User> ReadUsers()
        {
            string jsonUserFileText = File.ReadAllText(UserFileJson);
            if (jsonUserFileText == null || jsonUserFileText == "")
            {
                jsonUserFileText = File.ReadAllText(DefaultUserJson);
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
            File.WriteAllText(UserFileJson, jsonResult);
        }

    }
}
