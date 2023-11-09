using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string filePath = "data.json";

        // If the JSON file does not exist, create an empty dictionary
        Dictionary<string, string> data = File.Exists(filePath) ? ReadJsonFromFile<Dictionary<string, string>>(filePath) : new Dictionary<string, string>();

        // Add or update data in the dictionary
        data["Name"] = "John";
        data["Age"] = "30";

        // Serialize and save the dictionary to the JSON file
        WriteJsonToFile(filePath, data);

        // Read and display the data
        Dictionary<string, string> loadedData = ReadJsonFromFile<Dictionary<string, string>>(filePath);
        foreach (var item in loadedData)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static T ReadJsonFromFile<T>(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(json);
        }
        return default(T);
    }

    static void WriteJsonToFile<T>(string filePath, T data)
    {
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}
