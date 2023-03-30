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
	}

	public void Write(TvShow tvShow){
		/* 
			writes out all of the properties of the passed tvShow
			to a txt file which is named <tvShow_id>.txt
		*/
	}

	public void WriteAll(TvShow[] tvShows){
		/* 
			writes out all tvShows in the array passed. Each file
			is named the after the given tvShow's id: <tvShow_id>.txt,
			and will contain all properties of the tvShow.
		*/
	}

	public int CreateCountryDirectories(TvShow[] tvShows, string countryDirName){
        int count = 0;
		/*
			Inside of the WritePathDir, create a new directory named {countryDirName}
			if one does not already exist. Traverse into this directory. Then, create
			a directory for each country that appears in the tvShows array in the tvShow's
			OriginCountry property. There should only be one directory per country, so make
			sure not to create duplicate directories.

			Returns the total number of directories that were created.
		*/

        return count;
	}
	
	public void WriteShowsByCountry(TvShow[] tvShows, string countryDirName){
		/*
			Inside of the WriteDirPath directory, create a new directory named
			{countryDirName} if one does not already exist. Traverse into this directory
			and create a directory for each country. Inside of each country directory,
			write only those tvShows that have their OriginCountry equal to that country.
		*/
	}

	public void WritePosters(TvShow[] tvShows, string posterDirName){
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