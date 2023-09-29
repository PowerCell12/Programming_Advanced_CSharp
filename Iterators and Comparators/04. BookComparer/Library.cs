using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators;

public class Library: IEnumerable<Book>{

  private List<Book> books;
    
  public Library(params Book[] Books){
    this.books = Books.ToList();
  }
  
  public IEnumerator<Book> GetEnumerator(){
    return new LibraryIterator(books);
  }

  IEnumerator IEnumerable.GetEnumerator(){
    return GetEnumerator();
  }
  
  class LibraryIterator : IEnumerator<Book>
  {
      private int currentIndex = -1;
      private List<Book> Books;

      public LibraryIterator(List<Book> booiks){
        Reset();
        Books = booiks;
        Books.Sort(new BookComparator());
      }
    
      public Book Current => Books[currentIndex];

      object IEnumerator.Current => Current;

      public void Dispose(){}

      public bool MoveNext()
      {
        return ++currentIndex < Books.Count;
      }

      public void Reset()
      {
        currentIndex = -1;
      }

  
  }
}