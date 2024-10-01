using EadBackend.Repositories;
using EadBackend.DTOs;
using EadBackend.Models;

namespace EadBackend.Services
{
    public class ShopItemService : IShopItemService
    {
        private readonly IShopItemRepository _shopItemRepository;
        private readonly IShopRepository _shopRepository;

        public ShopItemService(IShopItemRepository shopItemRepository, IShopRepository shopRepository)
        {
            _shopItemRepository = shopItemRepository;
            _shopRepository = shopRepository;
        }

        public async Task<ShopItemDto> GetByIdAsync(string id)
        {
            var shopItem = await _shopItemRepository.GetByIdAsync(id);
            return MapToDto(shopItem);
        }

        public async Task<IEnumerable<ShopItemDto>> GetAllAsync()
        {
            var shopItems = await _shopItemRepository.GetAllAsync();
            return shopItems.Select(MapToDto);
        }

        public async Task<IEnumerable<ShopItemDto>> GetByShopIdAsync(string shopId)
        {
            var shopItems = await _shopItemRepository.GetByShopIdAsync(shopId);
            return shopItems.Select(MapToDto);
        }

        public async Task<ShopItemDto> CreateAsync(string shopId, string vendorId, CreateShopItemDto createShopItemDto)
        {
            var shop = await _shopRepository.GetByIdAsync(shopId);
            if (shop == null || shop.VendorId != vendorId)
                throw new UnauthorizedAccessException("Shop not found or you're not authorized to add items to it.");

            var shopItem = new ShopItem
            {
                Name = createShopItemDto.Name,
                InstockAmount = createShopItemDto.InstockAmount,
                Description = createShopItemDto.Description,
                ImageUrl = createShopItemDto.ImageUrl,
                ShopId = shopId
            };

            await _shopItemRepository.CreateAsync(shopItem);
            return MapToDto(shopItem);
        }

        public async Task<ShopItemDto> UpdateAsync(string id, string vendorId, UpdateShopItemDto updateShopItemDto)
        {
            var shopItem = await _shopItemRepository.GetByIdAsync(id);
            if (shopItem == null)
                throw new KeyNotFoundException("Shop item not found.");

            var shop = await _shopRepository.GetByIdAsync(shopItem.ShopId);
            if (shop == null || shop.VendorId != vendorId)
                throw new UnauthorizedAccessException("You're not authorized to update this shop item.");

            shopItem.Name = updateShopItemDto.Name;
            shopItem.InstockAmount = updateShopItemDto.InstockAmount;
            shopItem.Description = updateShopItemDto.Description;
            shopItem.ImageUrl = updateShopItemDto.ImageUrl;

            await _shopItemRepository.UpdateAsync(id, shopItem);
            return MapToDto(shopItem);
        }

        public async Task DeleteAsync(string id, string vendorId)
        {
            var shopItem = await _shopItemRepository.GetByIdAsync(id);
            if (shopItem == null)
                throw new KeyNotFoundException("Shop item not found.");

            var shop = await _shopRepository.GetByIdAsync(shopItem.ShopId);
            if (shop == null || shop.VendorId != vendorId)
                throw new UnauthorizedAccessException("You're not authorized to delete this shop item.");

            await _shopItemRepository.DeleteAsync(id);
        }

        private ShopItemDto MapToDto(ShopItem shopItem) => new ShopItemDto
        {
            Id = shopItem.Id,
            Name = shopItem.Name,
            InstockAmount = shopItem.InstockAmount,
            Description = shopItem.Description,
            ImageUrl = shopItem.ImageUrl,
            ShopId = shopItem.ShopId
        };
    }
}