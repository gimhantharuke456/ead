using EadBackend.Repositories;
using EadBackend.DTOs;
using EadBackend.Models;

namespace EadBackend.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShopItemRepository _shopItemRepository;

        private readonly IUserRepository _userRepositary;

        private readonly IShopRepository _shopRepositary;

        public OrderService(IOrderRepository orderRepository, IShopItemRepository shopItemRepository, IUserRepository userRepository, IShopRepository shopRepository)
        {
            _orderRepository = orderRepository;
            _shopItemRepository = shopItemRepository;
            _userRepositary = userRepository;
            _shopRepositary = shopRepository;
        }

        public async Task<OrderDto> GetByIdAsync(string id)
        {
            var order = await _orderRepository.GetByIdAsync(id);
            return MapToDto(order);
        }

        public async Task<IEnumerable<OrderGetDto>> GetAllAsync()
        {
            var response = new List<OrderGetDto>(); // Initialize the response list
            var orders = await _orderRepository.GetAllAsync(); // Get all orders from the repository

            foreach (var order in orders)
            {
                // Fetch the associated user and shop based on their IDs
                User user = await _userRepositary.GetByIdAsync(order.UserId);
                Shop shop = await _shopRepositary.GetByIdAsync(order.ShopId);
                ShopItem item = await _shopItemRepository.GetByIdAsync(order.ShopItemId);

                // Create the OrderGetDto and populate it with order, user, and shop data
                OrderGetDto dto = new OrderGetDto
                {
                    Id = order.Id,
                    ShopItemId = order.ShopItemId,
                    ShopId = order.ShopId,
                    UserId = order.UserId,
                    Quantity = order.Quantity,
                    Address = order.Address,
                    Status = order.Status,
                    UserName = user?.FirstName ?? "" + user?.LastName ?? "", // Assuming 'Username' exists in the User model
                    ShopName = shop?.Name ?? "",
                    ItemName = item?.Name ?? ""
                };

                // Add the DTO to the response list
                response.Add(dto);
            }

            return response; // Return the list of OrderGetDto
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
        private OrderGetDto MapToGetDto(Order order, User user, Shop shop) => new OrderGetDto
        {
            Id = order.Id,
            ShopItemId = order.ShopItemId,
            ShopId = order.ShopId,
            UserId = order.UserId,
            Quantity = order.Quantity,
            Address = order.Address,
            Status = order.Status,
            UserName = user.FirstName + user.LastName,
            ShopName = shop.Name
        };
    }
}
