using System.Collections.Generic;
namespace IteratorsAndComparators;

public class BookComparator: IComparer<Book>{

  public int Compare(Book first, Book second){
    
      int final = first.Title.CompareTo(second.Title);

      if (final ==0){
        final = second.Year.CompareTo(first.Year);
      }

      return final;

    
  }

  
}