using EadBackend.DTOs;

namespace EadBackend.Services
{
    public interface IOrderService
    {
        Task<OrderDto> GetByIdAsync(string id);
        Task<IEnumerable<OrderDto>> GetAllAsync();
        Task<OrderDto> CreateAsync(string userId, CreateOrderDto createOrderDto);
        Task<OrderDto> UpdateAsync(string id, string userId, UpdateOrderDto updateOrderDto);
        Task DeleteAsync(string id, string userId);
    }
}
