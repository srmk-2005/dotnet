using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

class Food
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int WaitingTime { get; set; }
}

class JsonDemo
{
    static void Main()
    {
        string txtPath = "food.txt";
        string jsonPath = "food.json";

        List<Food> foods = new List<Food>();

        string choice = "yes";

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            TypeInfoResolver = new DefaultJsonTypeInfoResolver()
        };

        while (choice.ToLower() == "yes")
        {
            Food food = new Food();

            Console.Write("Enter Food Name: ");
            food.Name = Console.ReadLine();

            Console.Write("Enter Price: ");
            food.Price = double.Parse(Console.ReadLine());

            Console.Write("Enter Waiting Time (minutes): ");
            food.WaitingTime = int.Parse(Console.ReadLine());

            foods.Add(food);

            // Store in TXT file
            using (StreamWriter sw = new StreamWriter(txtPath, true))
            {
                sw.WriteLine("Name: " + food.Name);
                sw.WriteLine("Price: " + food.Price);
                sw.WriteLine("WaitingTime: " + food.WaitingTime);
                sw.WriteLine("--------------------");
            }

            // Store all records in JSON file
            string json = JsonSerializer.Serialize(foods, options);

            File.WriteAllText(jsonPath, json);

            Console.Write("\nDo you want to add another food? (yes/no): ");
            choice = Console.ReadLine();
        }

        Console.WriteLine("\nFood details saved successfully!");
    }
}