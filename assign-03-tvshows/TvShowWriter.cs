using System;
using System.IO;

public class TvShowWriter{
	/* 
		BaseDirPath is the directory that your program should always
		return to after traversing into other directories. This should
		be an absolute path.
	*/
	public string BaseDirPath {get; set;}
	public string WriteDirPath {get; set;}
	
	/*
		ALL WRITE METHODS WRITE TO THE WriteDirPath UNLESS OTHERWISE SPECIFIED.
		IF THE DIRECTORY WriteDirPath DOES NOT EXIST, HAVE YOUR PROGRAM CREATE IT.

		UNLESS OTHERWISE SPECIFIED AT THE END OF EVERY WRITE METHOD OR METHOD 
		THAT CREATES ONE OR MORE DIRECTORIES, THE PROGRAM SHOULD ALWAYS MOVE 
		BACK TO THE BaseDirPath.
	*/
	
	public TvShowWriter(string baseDirectory, string writeDirectoryPath){
		//set instance vars
		this.WriteDirPath = writeDirectoryPath;
		this.BaseDirPath = baseDirectory;
	}

	public void Write(TvShow tvShow, bool defaultPath = true){
		/* 
			writes out all of the properties of the passed tvShow
			to a txt file which is named <tvShow_id>.txt
		*/
		if(defaultPath){
			if(!Directory.Exists(this.WriteDirPath)){
				Directory.CreateDirectory(this.WriteDirPath);
			}
			Directory.SetCurrentDirectory(this.WriteDirPath);
		}

		string fileName = $"{tvShow.Id}.txt";
		string contents = $@"TV Show
				ID: {tvShow.Id}
				Backdrop Path: {tvShow.BackdropPath}
				Title: {tvShow.Name}
				Country: {tvShow.OriginCountry}
				Language: {tvShow.OriginalLanguage}
				OG Name: {tvShow.OriginalName}
				Overview: {tvShow.Overview}
				Popularity: {tvShow.Popularity}
				Poster Path: {tvShow.PosterPath}
				Vote Avg: {tvShow.VoteAverage}
				Vote Cnt: {tvShow.VoteCount}
				";

		 File.WriteAllText(fileName, contents);

		if(defaultPath){
			Directory.SetCurrentDirectory(this.BaseDirPath);
		}
			
	}
	

	public void WriteAll(List<TvShow> tvShows){
		/* 
			writes out all tvShows in the array passed. Each file
			is named the after the given tvShow's id: <tvShow_id>.txt,
			and will contain all properties of the tvShow.
		*/
		foreach(var show in tvShows){
			this.Write(show);
		}

	}

	public int CreateCountryDirectories(List <TvShow> tvShows, string countryDirName){
        int count = 0;
		/*
			Inside of the WritePathDir, create a new directory named {countryDirName}
			if one does not already exist. Traverse into this directory. Then, create
			a directory for each country that appears in the tvShows array in the tvShow's
			OriginCountry property. There should only be one directory per country, so make
			sure not to create duplicate directories.

			Returns the total number of directories that were created.
		*/

		HashSet<string> originCountry = new HashSet<string>();
		foreach(TvShow show in tvShows){
			originCountry.Add(show.OriginCountry);
		}
		Directory.SetCurrentDirectory(this.WriteDirPath);
		if(!Directory.Exists(countryDirName)){
				Directory.CreateDirectory(countryDirName);
		}
		Directory.SetCurrentDirectory(countryDirName);

		foreach(string country in originCountry){
			if(!Directory.Exists(country)){
				Directory.CreateDirectory(country);
				count++;
			}
		}

		Directory.SetCurrentDirectory(this.BaseDirPath);


        return count;
	}
	
	public void WriteShowsByCountry(List <TvShow> tvShows, string countryDirName){
		/*
			Inside of the WriteDirPath directory, create a new directory named
			{countryDirName} if one does not already exist. Traverse into this directory
			and create a directory for each country. Inside of each country directory,
			write only those tvShows that have their OriginCountry equal to that country.
		*/
		this.CreateCountryDirectories(tvShows, countryDirName);

		Directory.SetCurrentDirectory(this.WriteDirPath);
		Directory.SetCurrentDirectory(countryDirName);
		
	
		// move into the writedirpath
		// move into the countrydirname
		string[] countryDirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
		// foreach( in tvShows){
		// 	foreach(tvShows){

		// 	}
		// }
		// foreach countryDirs{
			// foreach tvshows{
				// check to see if the show.originCountry == Path.GetfileName(country)
					// if it is => write the country here:
						// this.Write(show, false)
			// }

			// move back one directory
		//}
		foreach(string country in countryDirs){
			string countryDir = Path.GetFileName(country);
			Directory.SetCurrentDirectory(country);
			foreach(TvShow show in tvShows){
				if(show.OriginCountry == countryDir){
					this.Write(show, false);
				}
			}
			Directory.SetCurrentDirectory("..");
		}
	}


	public void WritePosters(List <TvShow> tvShows, string posterDirName){
		/*
			OPTIONAL EXTRA CREDIT METHOD. ADDITIONAL 10 POINTS.
			MAKE AN ATTEMPT FOR PARTIAL EXTRA CREDIT AS WELL.

			Inside of the WriteDirPath directory, create a new directory named
			{posterDirName}. Traverse into this directory. Inside of this directory,
			create an HTML document for each tvShow named <tvShow_id>.html. This
			HTML document will have basic HTML written to it as is given in the HTML
			Template section of this document. Notice in the Body subsection that
			there is a {tvShow.PosterPath} variable for you already written in
			which will inject the single tvShow's image url.

			Create any helper methods as you see fit to do so.
				Just a suggestion, not a requirement... but maybe try to have
				one method for each the Header, Body, and Footer, that returns a
				string for the markup for that section. In the case of the body,
				you would need to have that method take in a tvShow as a parameter.
				Once you wrote each method, you could call each of them here in
				this WritePosters() method and create all of the content that
				will need to be written inside of each HTML document for you to
				write out.
				For example:
					string html = this.Header();
					html += this.<someOtherMethod>();
											...
				Just a thought...
		*/	
	}

}