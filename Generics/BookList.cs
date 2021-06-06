using System;
using Generics.Models;

namespace Generics
{
  public class BookList
  {
    public void Add (Book book)
    {
      throw new NotImplementedException();
    }

    public Book this[int index] 
    { 
      get { throw new NotImplementedException(); }
    }
  }

  public class GenericDictonary<TKey, TValue>
  {
      public void Add(TKey key, TValue value)
      {
      }
  }

  public class GenericList<T>
  {
    public void Add(T value)
    {
    }

    public T this[int index] 
    { 
      get { throw new NotImplementedException(); }
    }
  }

}