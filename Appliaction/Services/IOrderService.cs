using Model.Models;

namespace Appliaction.Services
{
    public interface IOrderService
    {
        IQueryable<Order> GetAllOrders();

        Order addOrder(Order order);   
        /// <summary>
        ///  this function need dtos  to  mapp data 
        /// </summary>
        /// <param name="productsID"></param>
        /// <param name="orderID"></param>
        /// <returns></returns>
        ProductInOrder AddListOfProducts (List<int> productsID ,int orderID );
    }
}