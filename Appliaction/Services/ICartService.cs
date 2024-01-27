using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public interface ICartService 
    {
        CartItem addNewCart(int UserID);
        CartItem GetCartByUserID(int USerID);
        ProductCartItem addproductToCart(int ProID,int CartID );
        
    }
}
