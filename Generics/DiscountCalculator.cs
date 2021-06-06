using Generics.Models;

namespace Generics
{
  // Cosntaint to a Product (for this demo) class
  // where T : Product -> T can be the Product class or it's derived classes ...
  public class DiscountCalculator<TProduct> where TProduct : Product
  {
      public float CalculateDiscount(TProduct product)
      {
        return product.Price;
      }
  }
}
