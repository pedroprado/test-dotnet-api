using System.Collections.Generic;
using System.Linq;
using web_api_example.Models;

namespace web_api_example.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly RepositoryContext _repositoryContext;

        public OrderRepository(RepositoryContext repositoryContext){
            this._repositoryContext = repositoryContext;
        }
        public void createOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void deleteOrderById(int order_id)
        {
            throw new System.NotImplementedException();
        }

        public Order getOrderById(int order_id)
        {
            return _repositoryContext.orders.FirstOrDefault(order => order.orderId == order_id);
        }

        public IEnumerable<Order> getOrders()
        {
            throw new System.NotImplementedException();
        }

        public void updateOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
}