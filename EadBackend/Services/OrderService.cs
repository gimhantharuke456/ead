using EadBackend.Repositories;
using EadBackend.DTOs;
using EadBackend.Models;

namespace EadBackend.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShopItemRepository _shopItemRepository;

        public OrderService(IOrderRepository orderRepository, IShopItemRepository shopItemRepository)
        {
            _orderRepository = orderRepository;
            _shopItemRepository = shopItemRepository;
        }

        public async Task<OrderDto> GetByIdAsync(string id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            return MapToDto(order);
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return orders.Select(MapToDto);
        }

        public async Task<OrderDto> CreateAsync(string userId, CreateOrderDto createOrderDto)
        {
            var shopItem = await _shopItemRepository.GetByIdAsync(createOrderDto.ShopItemId);
            if (shopItem == null)
                throw new KeyNotFoundException("Shop item not found.");

            var order = new Order
            {
                ShopItemId = createOrderDto.ShopItemId,
                ShopId = createOrderDto.ShopId,
                UserId = createOrderDto.UserId,
                Quantity = createOrderDto.Quantity,
                Address = createOrderDto.Address,
                Status = createOrderDto.Status
            };

            await _orderRepository.CreateAsync(order);
            return MapToDto(order);
        }

        public async Task<OrderDto> UpdateAsync(string id, string userId, UpdateOrderDto updateOrderDto)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
                throw new KeyNotFoundException("Order not found.");

            if (order.UserId != userId)
                throw new UnauthorizedAccessException("You're not authorized to update this order.");

            order.Quantity = updateOrderDto.Quantity;
            order.Address = updateOrderDto.Address;
            order.Status = updateOrderDto.Status;

            await _orderRepository.UpdateAsync(id, order);
            return MapToDto(order);
        }

        public async Task DeleteAsync(string id, string userId)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            if (order == null)
                throw new KeyNotFoundException("Order not found.");

            if (order.UserId != userId)
                throw new UnauthorizedAccessException("You're not authorized to delete this order.");

            await _orderRepository.DeleteAsync(id);
        }

        private OrderDto MapToDto(Order order) => new OrderDto
        {
            Id = order.Id,
            ShopItemId = order.ShopItemId,
            ShopId = order.ShopId,
            UserId = order.UserId,
            Quantity = order.Quantity,
            Address = order.Address,
            Status = order.Status
        };
    }
}
