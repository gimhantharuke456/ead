using EadBackend.Models;

namespace EadBackend.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(string id);
        Task<IEnumerable<Order>> GetAllAsync();
        Task CreateAsync(Order order);
        Task UpdateAsync(string id, Order order);
        Task DeleteAsync(string id);
    }
}
