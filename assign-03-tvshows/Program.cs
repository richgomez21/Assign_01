using System; 
using System.IO;
using System.Text.Json;

string jsonFile = @"./tvShows.json";

var json = File.ReadAllText(jsonFile);

// Console.WriteLine(json);
var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};

Company microsoft = JsonSerializer.Deserialize<Company>(json, options);
