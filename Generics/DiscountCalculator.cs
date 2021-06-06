using Generics.Models;

namespace Generics
{
  // Cosntaint to a class
  // where T : Product -> T can be the Product class (for this demo) or it's derived classes ...
  public class DiscountCalculator<TProduct> where TProduct : Product
  {
      public float CalculateDiscount(TProduct product)
      {
        return product.Price;
      }
  }
}
