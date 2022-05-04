namespace ShoppingCart.ShoppingCarts
{
  public interface IShoppingCartStore
  {
    ShoppingCart Get(int userId);
    void Save(ShoppingCart shoppingCart);
  }
}