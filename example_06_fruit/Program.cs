using System;
using System.IO;
using System.Text.Json;
using BCrypt.Net;

string filePath = "fruits.json";
var jsonString = File.ReadAllText(filePath);

Console.WriteLine(jsonString);

var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

List<Fruit> fruitList = JsonSerializer.Deserialize< List<Fruit> >(jsonString, options);

// loop through fruits and print out: <fruit_name: <fruit_color>

HashSet<string> fruitColors = new HashSet<string>();
foreach(Fruit fruit in fruitList){
    fruitColors.Add(fruit.Color);
};


// foreach(Fruit fruit in fruitList){
//     Console.WriteLine($"{fruit.Name}: {fruit.Color}");
// };




