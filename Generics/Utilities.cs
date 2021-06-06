using System;

namespace Generics
{
  public class Utilities<T> where T : IComparable
    {
        public int Max( int a, int b)
        {
          return a > b ? a : b ;
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
