using System.Collections;
using System.Collections.Generic;
namespace Final;

public class ListyIterator<T>{

  private List<T> coll;
  private int index;
    
  public ListyIterator(List<T> Coll){
    coll = Coll;
    index = 0;
  }

  public bool Move(){
  
      if (HasNext()){
        index++;
        return true;
      }  
      else{
        return false;
      }
    
  }

  public bool HasNext(){

    if (index + 1 == coll.Count){
      return false;        
    }
    else{ return true;}
    
  }

  public string Print(){

    if (coll.Count == 0){
      return "Invalid Operation!";
    }
    else{
      return $"{coll[index]}";
    }
    
  }
  
  
}