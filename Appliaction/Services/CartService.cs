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


        CartItem ICartService.GetCartByUserID(int USerID)
        {
            return cartRepository.GetCartByUserID(USerID);
        }
        CartItem ICartService.addNewCart(int UserID)
        {
            CartItem cartItem = new CartItem() { User_Id = UserID, };
          return  cartRepository.add(cartItem);
            
        }

        ProductCartItem ICartService.addproductToCart(int ProID, int CartID)
        {
            ProductCartItem productCart = new ProductCartItem() { CartId = CartID , Pro_Id= ProID  };
            // قبل ما يشيف ي شيك بال  productID and cartID  
            // عشان لو البرودكت مضاف قبل كدا يزود واحد ف الكونتيتي 

            return cartproudect.add(productCart);
        }
    }
}
