using System.Collections.Generic;

namespace IteratorsAndComparators;

public class Library{
  

  private List<Book> books;

  public Library(params Book[] Books){
    this.books = new List<Book>(Books);
  }
  
  
  
}