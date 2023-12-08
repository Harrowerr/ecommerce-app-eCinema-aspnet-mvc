using ecommerce_app.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce_app.Data.ViewComponents
{
    public class ShoppingCartSummary:ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;

        }

        public IViewComponentResult Invoke() //Adding items to the basket icon
        {
            var items = _shoppingCart.GetShoppingCartItems();

            return View(items.Count);
        }

    }
}
