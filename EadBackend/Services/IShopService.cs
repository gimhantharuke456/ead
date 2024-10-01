using EadBackend.DTOs;

namespace EadBackend.Services
{
    public interface IShopService
    {
        Task<ShopDto> GetByIdAsync(string id);
        Task<IEnumerable<ShopDto>> GetAllAsync();
        Task<IEnumerable<ShopDto>> GetByVendorIdAsync(string vendorId);
        Task<ShopDto> CreateAsync(string vendorId, CreateShopDto createShopDto);
        Task<ShopDto> UpdateAsync(string id, string vendorId, UpdateShopDto updateShopDto);
        Task DeleteAsync(string id, string vendorId);
    }
}