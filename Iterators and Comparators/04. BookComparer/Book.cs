using System.Collections.Generic;
using System;

namespace IteratorsAndComparators;

public class Book : IComparable<Book>{

  public string Title {set; get;}
  public int Year {set; get;}
  public List<string> Authors {set; get;}

  public Book(string title, int year, params string[] authors){
    this.Title = title;
    this.Year = year;
    this.Authors = new List<string>(authors);
  }

  public override string ToString(){

    return $"{Title} - {Year}";
    
  }

  public int CompareTo(Book other)
  {
      int final = Year.CompareTo(other.Year);

      if (final == 0){
        final = Title.CompareTo(other.Title);
      }

      return final;
  }



}