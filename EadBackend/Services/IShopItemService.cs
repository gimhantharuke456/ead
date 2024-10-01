using EadBackend.DTOs;

namespace EadBackend.Services
{
    public interface IShopItemService
    {
        Task<ShopItemDto> GetByIdAsync(string id);
        Task<IEnumerable<ShopItemDto>> GetAllAsync();
        Task<IEnumerable<ShopItemDto>> GetByShopIdAsync(string shopId);
        Task<ShopItemDto> CreateAsync(string shopId, string vendorId, CreateShopItemDto createShopItemDto);
        Task<ShopItemDto> UpdateAsync(string id, string vendorId, UpdateShopItemDto updateShopItemDto);
        Task DeleteAsync(string id, string vendorId);
    }
}