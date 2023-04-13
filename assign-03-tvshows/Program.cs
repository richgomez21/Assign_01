using System;
using System.IO;
using System.Text.Json;
string jsonFile = @"./tvShows.json";
var json = File.ReadAllText(jsonFile);
// // Console.WriteLine(json);
var options = new JsonSerializerOptions(){PropertyNameCaseInsensitive = true};
List<TvShow> shows = JsonSerializer.Deserialize<List<TvShow>>(json, options);
/*************************************************************
SOME EXAMPLES OF GETTING DATA OUT OF THE shows LIST ABOVE
*************************************************************/
//access the show at the 0th index of the list and print out the PosterPath attribute
Console.WriteLine(shows[0].PosterPath);
//get a single TvShow out of the 16th index if the list and put into variable
TvShow singleShow = shows[16];
//print out the name of the singleShow
Console.WriteLine(singleShow.Name);

string showDir = "./tvshow_directory";
string baseDirectory = Directory.GetCurrentDirectory();
TvShow showA = shows[2];
TvShowWriter showWriter = new TvShowWriter(baseDirectory, showDir);
showWriter.Write(showA);

showWriter.WriteAll(shows);



