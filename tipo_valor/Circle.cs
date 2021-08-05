using System;

namespace tipo_valor
{
  public struct Circle
  {
    private int _redious;
    public Circle(int _redious)
    {
      this._redious = _redious;
    }

    public double Circunference 
    {
       get { return 2 * this._redious * Math.PI; }
    }

    public int Redious 
    { 
      get { return _redious; } 
      set { _redious = value; } 
    }

    public void SubtractRedious ()
    {
      if( _redious > 1) {
        _redious--;
      }
    }

    public void SubtractRedious(int value)
    {
      if (_redious - value > 1)
      {
        _redious -= value ;
      }
    }
  }

  // Struct cannot be inherited from other struct or class, however, can implement interfaces
  public struct ColoredCircle : IComparable
  {
    private string color;

    public ColoredCircle(string color)
      {
      this.color = color;
    }
    public int CompareTo(object obj)
    {
      throw new NotImplementedException();
    }
  }


}