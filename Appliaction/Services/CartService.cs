using Appliaction.Contract;
using Infrastructure.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class CartService : ICartService
    {
        private readonly ICartRepository cartRepository;
        private readonly ICartproudectRepository cartproudect;
        public CartService(ICartRepository _cartRepository, ICartproudectRepository _cartproudect)
        {
            cartRepository = _cartRepository;
            cartproudect = _cartproudect;
        }


        public CartItem GetCartByUserID(int USerID)
        {
            return cartRepository.GetCartByUserID(USerID);
        }
        public CartItem addNewCart(int UserID)
        {
            CartItem cartItem = new CartItem() { User_Id = UserID, };
          return  cartRepository.add(cartItem);
            
        }

        public ProductCartItem addproductToCart(int ProID, int CartID)
        {

            // قبل ما يشيف ي شيك بال  productID and cartID  
            // عشان لو البرودكت مضاف قبل كدا يزود واحد ف الكونتيتي 
             (bool, ProductCartItem) result  = cartproudect.CheckExeistProduct(ProID, CartID);

            if(result.Item1 == true)
            {
                result.Item2.Quantity += 1;
              return  cartproudect.update(result.Item2);
            }
            else
            {
                ProductCartItem productCart = new ProductCartItem() { CartId = CartID, Pro_Id = ProID };
                return cartproudect.add(productCart);
            }

           
        }
    }
}
