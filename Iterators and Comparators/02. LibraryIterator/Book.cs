using System.Collections.Generic;

namespace IteratorsAndComparators;

public class Book{

  public string Title {set; get;}
  public int Year {set; get;}
  public List<string> Authors {set; get;}

  public Book(string title, int year, params string[] authors){
    this.Title = title;
    this.Year = year;
    this.Authors = new List<string>(authors);
  }
  
}