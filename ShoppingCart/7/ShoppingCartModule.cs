using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;
using Nancy.ModelBinding;

namespace ShoppingCart.ShoppingCarts
{
    public class ShoppingCartModule:NancyModule
    {
        public ShoppingCartModule(IShopingCartStore shopingCartStore) :base("/shoppingcart")
        {
            Get("/{userid:int}",parameters =>
            {
                var userId = (int)parameters.userid;
                return shopingCartStore.Get(userId);
            });
        }
    }
}
