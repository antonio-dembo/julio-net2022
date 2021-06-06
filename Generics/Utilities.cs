using System;

namespace Generics
{
  // Interface type Cosntraint
  // where T : IComparable -> T must be an interface (Icomparable for this demo) or a derived class 
  // or derived interface.

  // parameterless constructor cosntraint
  //  where T : new() -> T is an object with a parameterless constructor
  public class Utilities<T> where T : IComparable , new ()
    {
        public int Max( int a, int b)
        {
          return a > b ? a : b ;
        }

        public void DoSomething(T value)
        {
          var obj = new T();
        }
        
        public T Max (T a, T b)
        {
          // at this time the compiler doesn't know the type of T.
          // so it cannot apply comparison with a and b.
          // He thinks a and b are both objects.
          // Solution: Use contraints: 
          // we want to assume that both a and be implements the IComparable interface, which provides a method called
          // CompareTo(). with that we can compare this two objects. that's a use case where we need to appply a constraints
          return a.CompareTo(b) > 0 ? a : b ; 
        }
    }
}
