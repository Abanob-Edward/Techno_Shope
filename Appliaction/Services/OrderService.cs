using Appliaction.Contract;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliaction.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;
        public OrderService(IOrderRepository _orderRepository)
        {
            this.orderRepository = _orderRepository;
        }


        public IQueryable<Order> GetAllOrders()
        {
            
            return orderRepository.getAllwithUser();
        }

        public Order UpdateOrderStatus(int orderID , OrderStatus status)
        {
            Order order = orderRepository.getByID(orderID);
            order.OrderStatus = status;
           return   orderRepository.update(order);
        }

        public Order addOrder(Order order)
        {
           return orderRepository.add(order);
        }

        public ProductInOrder AddListOfProducts(List<int> productsID, int orderID)
        {
            throw new NotImplementedException();
        }
    }
}
