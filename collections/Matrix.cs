namespace collections
{
  public class Matrix
  {
      private double[,] storage = new double[3, 3];
      public double this [int row, int column]
      {
          // The embedded array will throw out of range exceptions as appropriate.
          get => storage[row, column]; 
          set => storage[row, column] = value; 
      }

      
  }
}