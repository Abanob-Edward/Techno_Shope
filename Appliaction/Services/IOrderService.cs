using Model.Models;

namespace Appliaction.Services
{
    public interface IOrderService
    {
        IQueryable<Order> GetAllOrders();
    }
}